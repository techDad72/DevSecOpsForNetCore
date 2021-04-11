using System;
using Xunit;
using ConsoleApp;

namespace ConsoleApp.Tests
{
    public class MathTests
    {
        [Fact]
		public void Add_2_Plus_2_Equals_4()
		{
			//Arrange
			//Nothing to arrange
			
			//Act
			int result = Arithmetic.Add(2, 2);
			
			//Assert
			Assert.Equal(4, result);
		}
    }
}
