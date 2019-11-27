﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricInductance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricInductanceTestsBase
    {
        protected abstract double HenriesInOneHenry { get; }
        protected abstract double MicrohenriesInOneHenry { get; }
        protected abstract double MillihenriesInOneHenry { get; }
        protected abstract double NanohenriesInOneHenry { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double HenriesTolerance { get { return 1e-5; } }
        protected virtual double MicrohenriesTolerance { get { return 1e-5; } }
        protected virtual double MillihenriesTolerance { get { return 1e-5; } }
        protected virtual double NanohenriesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricInductance((double)0.0, ElectricInductanceUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_CreateQuantityAndAffectInfinityValue()
        {
            var positiveInfinityQuantity = new ElectricInductance(double.PositiveInfinity, ElectricInductanceUnit.Henry);
            var negativeInfinityQuantity = new ElectricInductance(double.NegativeInfinity, ElectricInductanceUnit.Henry);

            Assert.True(double.IsPositiveInfinity(positiveInfinityQuantity.Value));
            Assert.True(double.IsNegativeInfinity(negativeInfinityQuantity.Value));
        }

        [Fact]
        public void Ctor_WithNaNValue_CreateQuantityAndAffectNaNValue()
        {
            var nanQuantity = new ElectricInductance(double.NaN, ElectricInductanceUnit.Henry);
            Assert.True(double.IsNaN(nanQuantity.Value));
        }

        [Fact]
        public void HenryToElectricInductanceUnits()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            AssertEx.EqualTolerance(HenriesInOneHenry, henry.Henries, HenriesTolerance);
            AssertEx.EqualTolerance(MicrohenriesInOneHenry, henry.Microhenries, MicrohenriesTolerance);
            AssertEx.EqualTolerance(MillihenriesInOneHenry, henry.Millihenries, MillihenriesTolerance);
            AssertEx.EqualTolerance(NanohenriesInOneHenry, henry.Nanohenries, NanohenriesTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricInductance.From(1, ElectricInductanceUnit.Henry).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(1, ElectricInductance.From(1, ElectricInductanceUnit.Microhenry).Microhenries, MicrohenriesTolerance);
            AssertEx.EqualTolerance(1, ElectricInductance.From(1, ElectricInductanceUnit.Millihenry).Millihenries, MillihenriesTolerance);
            AssertEx.EqualTolerance(1, ElectricInductance.From(1, ElectricInductanceUnit.Nanohenry).Nanohenries, NanohenriesTolerance);
        }

        [Fact]
        public void FromHenries_WithInfinityValue_CreateQuantityAndAffectInfinityValue()
        {
            var positiveInfinityQuantity = ElectricInductance.FromHenries(double.PositiveInfinity);
            var negativeInfinityQuantity = ElectricInductance.FromHenries(double.NegativeInfinity);

            Assert.True(double.IsPositiveInfinity(positiveInfinityQuantity.Value));
            Assert.True(double.IsNegativeInfinity(negativeInfinityQuantity.Value));
        }

        [Fact]
        public void FromHenries_WithNanValue_CreateQuantityAndAffectNaNValue()
        {
            var nanQuantity = ElectricInductance.FromHenries(double.NaN);
            Assert.True(double.IsNaN(nanQuantity.Value));
        }

        [Fact]
        public void As()
        {
            var henry = ElectricInductance.FromHenries(1);
            AssertEx.EqualTolerance(HenriesInOneHenry, henry.As(ElectricInductanceUnit.Henry), HenriesTolerance);
            AssertEx.EqualTolerance(MicrohenriesInOneHenry, henry.As(ElectricInductanceUnit.Microhenry), MicrohenriesTolerance);
            AssertEx.EqualTolerance(MillihenriesInOneHenry, henry.As(ElectricInductanceUnit.Millihenry), MillihenriesTolerance);
            AssertEx.EqualTolerance(NanohenriesInOneHenry, henry.As(ElectricInductanceUnit.Nanohenry), NanohenriesTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var henry = ElectricInductance.FromHenries(1);

            var henryQuantity = henry.ToUnit(ElectricInductanceUnit.Henry);
            AssertEx.EqualTolerance(HenriesInOneHenry, (double)henryQuantity.Value, HenriesTolerance);
            Assert.Equal(ElectricInductanceUnit.Henry, henryQuantity.Unit);

            var microhenryQuantity = henry.ToUnit(ElectricInductanceUnit.Microhenry);
            AssertEx.EqualTolerance(MicrohenriesInOneHenry, (double)microhenryQuantity.Value, MicrohenriesTolerance);
            Assert.Equal(ElectricInductanceUnit.Microhenry, microhenryQuantity.Unit);

            var millihenryQuantity = henry.ToUnit(ElectricInductanceUnit.Millihenry);
            AssertEx.EqualTolerance(MillihenriesInOneHenry, (double)millihenryQuantity.Value, MillihenriesTolerance);
            Assert.Equal(ElectricInductanceUnit.Millihenry, millihenryQuantity.Unit);

            var nanohenryQuantity = henry.ToUnit(ElectricInductanceUnit.Nanohenry);
            AssertEx.EqualTolerance(NanohenriesInOneHenry, (double)nanohenryQuantity.Value, NanohenriesTolerance);
            Assert.Equal(ElectricInductanceUnit.Nanohenry, nanohenryQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            AssertEx.EqualTolerance(1, ElectricInductance.FromHenries(henry.Henries).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(1, ElectricInductance.FromMicrohenries(henry.Microhenries).Henries, MicrohenriesTolerance);
            AssertEx.EqualTolerance(1, ElectricInductance.FromMillihenries(henry.Millihenries).Henries, MillihenriesTolerance);
            AssertEx.EqualTolerance(1, ElectricInductance.FromNanohenries(henry.Nanohenries).Henries, NanohenriesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricInductance v = ElectricInductance.FromHenries(1);
            AssertEx.EqualTolerance(-1, -v.Henries, HenriesTolerance);
            AssertEx.EqualTolerance(2, (ElectricInductance.FromHenries(3)-v).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(2, (ElectricInductance.FromHenries(10)/5).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(2, ElectricInductance.FromHenries(10)/ElectricInductance.FromHenries(5), HenriesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricInductance oneHenry = ElectricInductance.FromHenries(1);
            ElectricInductance twoHenries = ElectricInductance.FromHenries(2);

            Assert.True(oneHenry < twoHenries);
            Assert.True(oneHenry <= twoHenries);
            Assert.True(twoHenries > oneHenry);
            Assert.True(twoHenries >= oneHenry);

            Assert.False(oneHenry > twoHenries);
            Assert.False(oneHenry >= twoHenries);
            Assert.False(twoHenries < oneHenry);
            Assert.False(twoHenries <= oneHenry);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.Equal(0, henry.CompareTo(henry));
            Assert.True(henry.CompareTo(ElectricInductance.Zero) > 0);
            Assert.True(ElectricInductance.Zero.CompareTo(henry) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.Throws<ArgumentException>(() => henry.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.Throws<ArgumentNullException>(() => henry.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricInductance.FromHenries(1);
            var b = ElectricInductance.FromHenries(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = ElectricInductance.FromHenries(1);
            var b = ElectricInductance.FromHenries(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = ElectricInductance.FromHenries(1);
            Assert.True(v.Equals(ElectricInductance.FromHenries(1), HenriesTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricInductance.Zero, HenriesTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.False(henry.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.False(henry.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricInductanceUnit.Undefined, ElectricInductance.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricInductanceUnit)).Cast<ElectricInductanceUnit>();
            foreach(var unit in units)
            {
                if(unit == ElectricInductanceUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricInductance.BaseDimensions is null);
        }
    }
}
