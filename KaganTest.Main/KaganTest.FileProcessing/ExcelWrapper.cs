using Aspose.Cells;

namespace KaganTest.FileProcessing
{
    public struct TestStepResult
    {
        public TestStepResult(int stepNumber, TimeSpan timeElapsed, bool isCorrect)
        {
            StepNumber = stepNumber;
            TimeElapsed = timeElapsed;
            IsCorrect = isCorrect;
        }
        public int StepNumber;
        public TimeSpan TimeElapsed;
        public bool IsCorrect;
    }

    public class KaganTestResult
    {
        public List<TestStepResult> StepResults;

        public readonly string UserId;
        public readonly DateTime TestDate;

        public KaganTestResult(string userId, DateTime testDate)
        {
            UserId = userId;
            TestDate = testDate;
        }
    }

    public class ExcelWrapper
    {

        private static Dictionary<int, string> ColumnConvertor = new Dictionary<int, string>
        {
            [0] = "A",
            [1] = "B",
            [2] = "C",
            [3] = "D",
            [4] = "E",
            [5] = "F",
            [6] = "G",
            [7] = "H",
            [8] = "I",
            [9] = "J",
            [10] = "K",
            [11] = "L",
            [12] = "M",
            [13] = "N",
            [14] = "O",
            [15] = "P",
            [16] = "Q",
            [17] = "R",
            [18] = "S",
            [19] = "U",
            [20] = "V",
            [21] = "W",
            [22] = "X",
            [23] = "Z",
            [24] = "AA",
            [25] = "AB",
            [26] = "AC",
            [27] = "AD",
        };

        private Worksheet _worksheet;
        private Workbook _workbook;
        private const int ROW_START_INDEX = 2;
        private const int COLUMN_START_INDEX = 5;
        private int _lastUserColumnIndex = -1;
        private int _nextUserColumnIndex => _lastUserColumnIndex++;

        public ExcelWrapper()
        {
            _workbook = new Workbook();
            _worksheet = _workbook.Worksheets[0];
        }


        public void Test(KaganTestResult result)
        {
#warning get this from excel!
            var userColumnIndex = GetUserColumnIndex();

            SaveResultsAnswer(userColumnIndex, result);
            SaveElapsedTime(userColumnIndex, result);
        }

        private int GetUserColumnIndex()
        {
            if (_lastUserColumnIndex == -1)
            {
                for (int i = COLUMN_START_INDEX; i < 1000; i++)
                {
                    var value = _worksheet.Cells[$"{ColumnConvertor[ROW_START_INDEX]}{i}"].StringValue;

                    if (string.IsNullOrEmpty(value))
                    {
                        _lastUserColumnIndex = i - 1;
                        return _nextUserColumnIndex;
                    }
                }

                throw new Exception("Не смог найти место для записи!");
            }
            else 
            {
                return _nextUserColumnIndex;
            } 
        }

        private void SaveResultsAnswer(int userColumnIndex, KaganTestResult result)
        {
            _worksheet.Cells[$"{ColumnConvertor[ROW_START_INDEX]}{userColumnIndex}"].PutValue(result.UserId);

            foreach (var stepResult in result.StepResults)
            {
                _worksheet.Cells[$"{ColumnConvertor[ROW_START_INDEX + stepResult.StepNumber]}{userColumnIndex}"].PutValue(stepResult.IsCorrect ? "Верно" : "Неверно");
            }
            //Save the Excel file.
            _workbook.Save($"..\\KaganTestResult.xlsx", SaveFormat.Xlsx);
        }

        private void SaveElapsedTime(int userColumnIndex, KaganTestResult result)
        {
            var startIndex = ROW_START_INDEX + ROW_START_INDEX + result.StepResults.Count;
            _worksheet.Cells[$"{ColumnConvertor[startIndex]}{userColumnIndex}"].PutValue(result.UserId);

            foreach (var stepResult in result.StepResults)
            {
                _worksheet.Cells[$"{ColumnConvertor[startIndex + stepResult.StepNumber]}{userColumnIndex}"].PutValue(stepResult.TimeElapsed.TotalSeconds);
            }
            //Save the Excel file.
            _workbook.Save($"..\\KaganTestResult.xlsx", SaveFormat.Xlsx);
        }
    }
}