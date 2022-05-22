using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using HotelISDTO;

namespace HotelISService.Tests
{
    [TestFixture]
    public class ApartmentDtoValidatorTest
    {
        ApartmentDtoValidator validator;

        public static IEnumerable ApartmentTestCasesValid
        {

            get
            {
                yield return new TestCaseData(new ApartmentDto()
                {
                    FloorNumber = 2,
                    HasStatusVip = true,
                    RoomsNumber = 1,
                    MaxCapacity = 1,
                    Price = 1,

                }).Returns(true);

                yield return new TestCaseData(new ApartmentDto()
                {
                    FloorNumber = 1,
                    HasStatusVip = false,
                    RoomsNumber = 1,
                    MaxCapacity = 1,
                    Price = 1,

                }).Returns(true);
            }
        }

        public static IEnumerable ApartmentTestCasesInvalid
        {

            get
            {
                yield return new TestCaseData(new ApartmentDto()
                {
                    FloorNumber = 1,
                    HasStatusVip = true,
                    RoomsNumber = 1,
                    MaxCapacity = 1,
                    Price = 1,

                }).Returns(false);

                yield return new TestCaseData(new ApartmentDto()
                {
                    FloorNumber = 0,
                    HasStatusVip = false,
                    RoomsNumber = 1,
                    MaxCapacity = 1,
                    Price = 1,

                }).Returns(false);
            }
        }

        //[SetUp]
        //public void SetUp()
        //{
        //    //var validator = new ApartmentDtoValidator();
        //}

        [Test]
        [TestCaseSource("ApartmentTestCasesValid")]
        public bool TestValidateApartment_Valid(ApartmentDto apartment)
        {
            validator = new ApartmentDtoValidator();
            bool output = validator.ValidateFields(apartment);
            //Assert.AreEqual(true, output);
            return output;
        }

    }
}