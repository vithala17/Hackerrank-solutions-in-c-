using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace HackerrankSolutions.Tests
{
    public class FraudulentActivityNotificationsTests
    {
        [Fact]
        public void Test1()
        {
            FraudulentActivityNotifications notifs = new FraudulentActivityNotifications();
            var actual = notifs.activityNotifications(new int[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 }, 5);
            var expected = 2;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            FraudulentActivityNotifications notifs = new FraudulentActivityNotifications();
            var actual = notifs.activityNotifications(new int[] { 1, 2, 3, 4, 4 }, 4);
            var expected = 0;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            FraudulentActivityNotifications notifs = new FraudulentActivityNotifications();

            string inputArray = File.ReadAllText("C:\\Users\\s_vithala\\Desktop\\fraudnotifTestcase.txt");

            int[] expenditure = Array.ConvertAll(inputArray.Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp));

            var actual = notifs.activityNotifications(expenditure, 30000);
            var expected = 0;

            Assert.Equal(expected, actual);
        }
    }
}
