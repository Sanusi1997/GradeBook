using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTest
    {

        [Fact]
        public void AddGradesWorksCorrectly()
        {
            //Given
            var book2 = new Book("Kemi");
            book2.AddGrades(-0.1);
            book2.AddGrades(100.5);
            book2.AddGrades(55.5);
            //When

            //Then

            Assert.Equal(1, book2.GetGrades().Count);

        }

        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrades(80);
            book.AddGrades(45);
            book.AddGrades(55);
            var actualAverage = 60;
            var actualHigh = book.GetGrades()[0];
            var actualLow = book.GetGrades()[1]; ;

            //act
            var expectedAverage = book.GetStatistics().average;
            var expectedHigh = book.GetStatistics().high;
            var expectedLow = book.GetStatistics().low;


            //assert
            Assert.Equal(expectedAverage, actualAverage);
            Assert.Equal(expectedLow, actualLow);
            Assert.Equal(expectedHigh, actualHigh);



        }
    }
}
