using Newtonsoft.Json;

namespace StatisticsTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMaximum()
        {
            // Arrange
            var source = JsonConvert.DeserializeObject<int[]>(File.ReadAllText("data.json"));
            Array.Sort(source);
            Array.Reverse(source);
            var expectedMaximum = source[0];

            // Act
            var actualMaximum = Statistics.Statistics.Maximum();

            // Assert
            Assert.Equal(expectedMaximum, actualMaximum);
        }

        [Fact]
        public void TestMinimum()
        {
            // Arrange
            var source = JsonConvert.DeserializeObject<int[]>(File.ReadAllText("data.json"));
            Array.Sort(source);
            var expectedMinimum = source[0];

            // Act
            var actualMinimum = Statistics.Statistics.Minimum();

            // Assert
            Assert.Equal(expectedMinimum, actualMinimum);
        }

        [Fact]
        public void TestMean()
        {
            // Arrange
            var source = JsonConvert.DeserializeObject<int[]>(File.ReadAllText("data.json"));
            var expectedMean = source.Average();

            // Act
            var actualMean = Statistics.Statistics.Mean();

            // Assert
            Assert.Equal(expectedMean, actualMean);
        }

        [Fact]
        public void TestMedian()
        {
            // Arrange
            var source = JsonConvert.DeserializeObject<int[]>(File.ReadAllText("data.json"));
            Array.Sort(source);
            var size = source.Length;
            int mid = size / 2;
            var expectedMedian = (size % 2 == 0) ? (source[mid - 1] + source[mid]) / 2.0 : source[mid];

            // Act
            var actualMedian = Statistics.Statistics.Median();

            // Assert
            Assert.Equal(expectedMedian, actualMedian);
        }

        [Fact]
        public void TestMode()
        {
            // Arrange
            var source = JsonConvert.DeserializeObject<int[]>(File.ReadAllText("data.json"));
            var expectedMode = Statistics.Statistics.Mode();

            // Act
            var actualMode = Statistics.Statistics.Mode();

            // Assert
            Assert.Equal(expectedMode[0], actualMode[0]);
        }

        [Fact]
        public void TestRange()
        {
            // Arrange
            var source = JsonConvert.DeserializeObject<int[]>(File.ReadAllText("data.json"));
            Array.Sort(source);
            var expectedRange = Statistics.Statistics.Range();

            // Act
            var actualRange = Statistics.Statistics.Range();

            // Assert
            Assert.Equal(expectedRange, actualRange);
        }

        [Fact]
        public void TestStandardDeviation()
        {
            // Arrange
            var source = JsonConvert.DeserializeObject<int[]>(File.ReadAllText("data.json"));
            var expectedStandardDeviation = Statistics.Statistics.StandardDeviation();

            // Act
            var actualStandardDeviation = Statistics.Statistics.StandardDeviation();

            // Assert
            Assert.Equal(expectedStandardDeviation, actualStandardDeviation);
        }

        [Fact]
        public void TestDescriptiveStatistics()
        {
            // Arrange
            var expectedStatistics = Statistics.Statistics.DescriptiveStatistics();

            // Act
            var actualStatistics = Statistics.Statistics.DescriptiveStatistics();

            // Assert
            Assert.Equal(expectedStatistics, actualStatistics);
        }
    }
}

