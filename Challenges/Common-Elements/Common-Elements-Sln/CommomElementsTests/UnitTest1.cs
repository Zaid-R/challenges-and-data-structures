using System;
using Xunit;
using CommonElements;
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace CommomElementsTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Common_Elements_Method()
        {
            // Act1
            int[] arr1 = { 1, 2, 3, 0 };
            int[] arr2 = { 2, 3, 4, 9 };
            int[] result = CommonElements.Program.CommonElements(arr1, arr2);
            // Assert1
            Assert.Equal(new int[] { 2, 3 },result);

            // Act2
             arr1 = new int[] { 79, 8, 15 };
             arr2 = new int[] { 23, 79, 8 };
            result = CommonElements.Program.CommonElements(arr1, arr2);
            // Assert2 
            Assert.Equal(new int[] { 79,8 }, result);

        }
    }
}