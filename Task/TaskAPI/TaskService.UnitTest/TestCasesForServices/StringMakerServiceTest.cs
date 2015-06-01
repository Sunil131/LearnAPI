using NUnit.Framework;
using TaskService.Services;
using Shouldly;


namespace TaskService.UnitTest.TestCasesForServices
{
    
    public class StringMakerServiceTest
    {
        /// <summary>
        /// Tests the Method MakeMyString for values 1 to 3
        /// </summary>
        
        public void TestDivisibilityByNumberThree()
        {
            //Arrange
            var testService = new StringMakerService();
            //ACT
            var collectedValue = testService.MakeMyString(1, 3); //Case to check for divisible by 3 i.e. from 1 to 3
            var comparisonValue = "1,2,Birch";
            //Assert
            collectedValue.ShouldMatch(comparisonValue); 

        }

        /// <summary>
        /// Tests the Method MakeMyString for values 1 to 5
        /// </summary>
        [Test]
        public void TestDivisibleByFive()
        {
            //Arrange
            var testService = new StringMakerService();           
            //Act
            var collectedValue = testService.MakeMyString(1, 5); //Case to check for divisible by 5 i.e. from 1 to 5
            var comparisonValue = "1,2,Birch,4,Telecomm";
            //Assert
            collectedValue.ShouldMatch(comparisonValue); //Assert
        }

        /// <summary>
        /// Test the method MakeMyString for both 3 and 5 by starting from ZERO
        /// </summary>
        [Test]
        public void TestDivisibilityByNumbesThreeAndFive()
        {
            //Arrange
            var testService = new StringMakerService();
            //Act
            var collectedValue = testService.MakeMyString(0, 15); //Case to check Counter start from 0 to 15
            var comparisonValue = "BirchTelecomm,1,2,Birch,4,Telecomm,Birch,7,8,Birch,Telecomm,11,Birch,13,14,BirchTelecomm";
            //Assert
            collectedValue.ShouldMatch(comparisonValue); //Assert
        }

        /// <summary>
        /// Test the method MakeMyString for only 5
        /// </summary>
        [Test]
        public void TestDivisibilityByOnlyNumberFive()
        {
            //Arrange
            var testService = new StringMakerService();
            //Act
            var collectedValue = testService.MakeMyString(5, 5);//Case to check only 5
            var comparisonValue = "Telecomm";
            //Assert
            collectedValue.ShouldMatch(comparisonValue); 
        }


        /// <summary>
        /// Tests the method MakeMyString for only 3
        /// </summary>
        [Test]
        public void TestDivisibilityByOnlyThree()
        {
            //Arrange
            var testService = new StringMakerService();   
            //Act
            var collectedValue = testService.MakeMyString(3, 3);//Case to check only 3
            var comparisonValue = "Birch";
            //Assert
            collectedValue.ShouldMatch(comparisonValue); 
        }

        /// <summary>
        /// Tests the method MakeMyString by passing high val to min and low value to max 
        /// </summary>
        [Test]
        public void TestDivisibilityByReversingMinAndMax()
        {
            //Arrange
            var testService = new StringMakerService();
            //Act
            var collectedValue = testService.MakeMyString(15, 1);//Case to check if maxVal and minVal are reversed
            var comparisonValue = "";
            //Assert
            collectedValue.ShouldMatch(comparisonValue); 
        }

        /// <summary>
        /// Test the method MakeMyString for both 3 and 5 by starting from 1
        /// </summary>
        [Test]
        public void TestDivisibilityByThreeAndFive()
        {

            //Arrange
            var testService = new StringMakerService();
            //Act
            var collectedValue = testService.MakeMyString(1, 15); //Case to check divisiblty for both 3 and 5 i.e. 1 to 15
            var comparisonValue = "1,2,Birch,4,Telecomm,Birch,7,8,Birch,Telecomm,11,Birch,13,14,BirchTelecomm";
            //Assert
            collectedValue.ShouldMatch(comparisonValue); 
        }

       
    }
}
