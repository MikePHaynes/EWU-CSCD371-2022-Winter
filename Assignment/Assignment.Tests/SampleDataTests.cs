﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Tests
{
    [TestClass]
    public class SampleDataTests
    {
        IEnumerator<string>? stringEnumerator;
        SampleData sampleData = new();

        [TestMethod]
        public void CsvRows_Read_Success()
        {
            Assert.IsNotNull(sampleData.CsvRows);
            Assert.AreEqual<int>(50, sampleData.CsvRows.Count());
            Assert.AreEqual<string>("1,Priscilla,Jenyns,pjenyns0@state.gov,7884 Corry Way,Helena,MT,70577", sampleData.CsvRows.First());
        }

        [TestMethod]
        public void People_Read_Success()
        {
            Assert.IsNotNull(sampleData.People);
            Assert.AreEqual<int>(50, sampleData.People.Count());
            Assert.AreEqual<string>("Arthur", sampleData.People.First().FirstName);
        }

        [TestMethod]
        public void GetUniqueSortedListOfStatesGivenCsvRows_Read_Success()
        {
            IEnumerable<string> states = sampleData.GetUniqueSortedListOfStatesGivenCsvRows();
            Assert.AreEqual<string>("AL", states.First());
            Assert.AreEqual<string>("WV", states.Last());
        }

        [TestMethod]
        public void GetAggregateSortedListOfStatesUsingCsvRows_Read_Success()
        {
            string states = sampleData.GetAggregateSortedListOfStatesUsingCsvRows();
            Assert.IsNotNull(states);
            Assert.AreNotEqual<string>(string.Empty, states);
        }

        [TestMethod]
        public void GetAggregateListOfStatesGivenPeopleCollection_Read_Success()
        {
            string states = sampleData.GetAggregateListOfStatesGivenPeopleCollection(sampleData.People);
            Assert.IsNotNull(states);
            Assert.AreNotEqual<string>(string.Empty, states);
        }

        [TestMethod]
        public void CsvRows_GetData_Success()
        {
            // Arrange.
            stringEnumerator = sampleData.CsvRows.GetEnumerator();
            string getData;

            // Act.
            while (stringEnumerator.MoveNext())
            {
                getData = stringEnumerator.Current;

                // Assert.
                Assert.IsNotNull(getData);
            }
        }

        [TestMethod]
        public void AssignmentSampleData_1stRowSkipped_Success()
        {
            // Arrange
            IEnumerable<string> csvRows = sampleData.CsvRows;

            // Act.

            // Assert.
            Assert.IsFalse(csvRows.First().Contains("Id"));
        }

        [TestMethod]
        public void GetUniqueSortedListOfStatesGivenCsvRows_isSorted()
        {
            // Arrange.
            List<string> list = sampleData.GetUniqueSortedListOfStatesGivenCsvRows().ToList();
            IEnumerable<string> temp = sampleData.CsvRows.Select(line => line.Split(',')).Select(x => x[6]).OrderBy(x => x).Distinct();

            // Act.

            // Assert.
            Assert.IsTrue(list.SequenceEqual(temp));
        }

        [TestMethod]
        public void GetUniqueSortedListOfStatesGivenCsvRows_HardCoded()
        {
            //not sure what we are supposed to be testing with the hard coded list
        }

        [TestMethod]
        public void GetAggregateSortedListOfStatesUsingCsvRows_OutputsUniqueandSorted()
        {
            // Arrange.
            string states = sampleData.GetAggregateSortedListOfStatesUsingCsvRows();

            // Assert.
            Assert.AreEqual<string>("AL, AZ, CA, DC, FL, GA, IN, KS, LA, MD, MN, MO, MT, NC, NE, NH, NV, NY, OR, PA, SC, TN, TX, UT, VA, WA, WV", states);
        }

        [TestMethod]
        public void People_populatesCorrectly()
        {
            // Arrange.
            IEnumerable<string> csvRows = sampleData.CsvRows;
            IEnumerable<IPerson> people = sampleData.People;

            // Assert.
            Assert.IsTrue(csvRows.Count() == people.Count());
        }

        [TestMethod]
        public void FilterByEmail_filtersCorrectly()
        {
            // Arrange.
            Predicate<string> filter = email;
            static bool email(string email) => email.Contains("pjenyns0@state.gov");
            IEnumerable<(string, string)> result = sampleData.FilterByEmailAddress(filter);

            // Act.
            var expected = ("Priscilla", "Jenyns");

            // Assert.
            Assert.AreEqual(expected, (result.First().Item1, result.First().Item2));
        }

        [TestMethod]
        public void GetAggregateListOfStatesGivenPeopleCollection_isUnique()
        {
            // Arrange.
            string uniqueRows = sampleData.GetAggregateSortedListOfStatesUsingCsvRows();
            string uniquePeople = sampleData.GetAggregateListOfStatesGivenPeopleCollection(sampleData.People);

            // Act.


            // Assert.
            Assert.AreEqual(uniqueRows, uniquePeople);
        }

    }
}
