using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KaganTest.FileProcessing
{
    public struct TestStep
    {
        public int Index;
        public bool IsRigthAnswer;
        public Uri PathToImage;

        public TestStep(int index, bool isRigthAnswer, Uri pathToImage)
        {
            Index = index;
            IsRigthAnswer = isRigthAnswer;
            PathToImage = pathToImage;
        }
    }

    public class TestStepCollection
    {
        public readonly List<TestStep> Answers;
        public readonly int Index;
        public readonly Uri RigthAnswerImagePath;
        public bool IsNeedToRecord;

        public TestStepCollection(int index, List<TestStep> steps, bool isNeedToRecord, Uri rigthAnswerImagePath)
        {
            Index = index;
            Answers = steps;
            IsNeedToRecord = isNeedToRecord;
            RigthAnswerImagePath = rigthAnswerImagePath;
        }
    }

    public sealed class Test
    {
        private readonly List<TestStepCollection> _steps;
        private int _currentStepIndex;

        public Test(List<TestStepCollection> steps)
        {
            _steps = steps;
            _currentStepIndex = -1;
        }

        public bool IsCanGetNext => _currentStepIndex < _steps.Count() - 1;

        public TestStepCollection GetNext()
        {
            _currentStepIndex++;
            return _steps[_currentStepIndex];
        }
    }

    public sealed class FileWrapper
    {
        private const string BASE_PATH = "..//KaganTest.Images";

        public Test LoadTest()
        {
            var steps = new List<TestStepCollection>(14);
            steps.AddRange(LoadTutorial());
            //steps.AddRange(LoadTestInternal());

            return new Test(steps);
        }

        private List<TestStepCollection> LoadTestInternal()
        {
            var result = new List<TestStepCollection>(12);

            var testFoldes = Directory.GetDirectories(BASE_PATH)
                .Where(folder => !folder.Contains("tutorial"));

            foreach (var folder in testFoldes)
                result.Add(LoadStepCollection(folder, true));

            return result;
        }

        private List<TestStepCollection> LoadTutorial()
        {
            var result = new List<TestStepCollection>(2);

            var tutorialFoldes = Directory.GetDirectories(BASE_PATH, "*tutorial");

            foreach (var folder in tutorialFoldes)
                result.Add(LoadStepCollection(folder, false));

            return result;
        }

        private TestStepCollection LoadStepCollection(string from, bool isNeedToRecord)
        {
            var fromParts = from.Split('\\');
            var testSteps = new List<TestStep>(8);
            var files = Directory.GetFiles(from);

            foreach (var file in files.Where(x => !x.Contains("answer")))
                testSteps.Add(LoadTestStep(file));

            if (!int.TryParse(fromParts[fromParts.Length - 1], out var testStepCollectionIndex))
            {
                var testStepCollectionIndexStr = fromParts[fromParts.Length - 1].Split('_')[0];

                testStepCollectionIndex = int.Parse(testStepCollectionIndexStr);
            }

            return new TestStepCollection(testStepCollectionIndex
                , testSteps
                , isNeedToRecord
                , new Uri(files.First(x => x.Contains("answer")), UriKind.Relative));
        }

        private TestStep LoadTestStep(string from)
        {
            var fromParts = from.Split('\\').Last().Split('.');

            if (!int.TryParse(fromParts[fromParts.Length - 2], out var testStepIndex))
            {
                var testStepIndexStr = fromParts[fromParts.Length - 2].Split('_')[0];

                testStepIndex = int.Parse(testStepIndexStr);
            }

            return new TestStep(testStepIndex, fromParts.Any(part => part.Contains('_')), new Uri(from, UriKind.Relative));
        }
    }
}
