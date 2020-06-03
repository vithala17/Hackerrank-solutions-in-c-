using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class PDFdesignerTests
    {
        [Fact]
        public void Test1()
        {
            PDFdesigner designer = new PDFdesigner();

            var actual = designer.designerPdfViewer(new int[] { 1,3,1,3,1,4,1,3,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5 }, "abc");

            int expected = 9;

            Assert.Equal(expected, actual);
        }
    }
}
