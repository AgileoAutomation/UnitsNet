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
    /// Test of RatioChangeRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RatioChangeRateTestsBase
    {
        protected abstract double DecimalFractionsPerSecondInOneDecimalFractionPerSecond { get; }
        protected abstract double PercentsPerSecondInOneDecimalFractionPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecimalFractionsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double PercentsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RatioChangeRate((double)0.0, RatioChangeRateUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_CreateQuantityAndAffectInfinityValue()
        {
            var positiveInfinityQuantity = new RatioChangeRate(double.PositiveInfinity, RatioChangeRateUnit.DecimalFractionPerSecond);
            var negativeInfinityQuantity = new RatioChangeRate(double.NegativeInfinity, RatioChangeRateUnit.DecimalFractionPerSecond);

            Assert.True(double.IsPositiveInfinity(positiveInfinityQuantity.Value));
            Assert.True(double.IsNegativeInfinity(negativeInfinityQuantity.Value));
        }

        [Fact]
        public void Ctor_WithNaNValue_CreateQuantityAndAffectNaNValue()
        {
            var nanQuantity = new RatioChangeRate(double.NaN, RatioChangeRateUnit.DecimalFractionPerSecond);
            Assert.True(double.IsNaN(nanQuantity.Value));
        }

        [Fact]
        public void DecimalFractionPerSecondToRatioChangeRateUnits()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(DecimalFractionsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(PercentsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.PercentsPerSecond, PercentsPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, RatioChangeRate.From(1, RatioChangeRateUnit.DecimalFractionPerSecond).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(1, RatioChangeRate.From(1, RatioChangeRateUnit.PercentPerSecond).PercentsPerSecond, PercentsPerSecondTolerance);
        }

        [Fact]
        public void FromDecimalFractionsPerSecond_WithInfinityValue_CreateQuantityAndAffectInfinityValue()
        {
            var positiveInfinityQuantity = RatioChangeRate.FromDecimalFractionsPerSecond(double.PositiveInfinity);
            var negativeInfinityQuantity = RatioChangeRate.FromDecimalFractionsPerSecond(double.NegativeInfinity);

            Assert.True(double.IsPositiveInfinity(positiveInfinityQuantity.Value));
            Assert.True(double.IsNegativeInfinity(negativeInfinityQuantity.Value));
        }

        [Fact]
        public void FromDecimalFractionsPerSecond_WithNanValue_CreateQuantityAndAffectNaNValue()
        {
            var nanQuantity = RatioChangeRate.FromDecimalFractionsPerSecond(double.NaN);
            Assert.True(double.IsNaN(nanQuantity.Value));
        }

        [Fact]
        public void As()
        {
            var decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(DecimalFractionsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.As(RatioChangeRateUnit.DecimalFractionPerSecond), DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(PercentsPerSecondInOneDecimalFractionPerSecond, decimalfractionpersecond.As(RatioChangeRateUnit.PercentPerSecond), PercentsPerSecondTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);

            var decimalfractionpersecondQuantity = decimalfractionpersecond.ToUnit(RatioChangeRateUnit.DecimalFractionPerSecond);
            AssertEx.EqualTolerance(DecimalFractionsPerSecondInOneDecimalFractionPerSecond, (double)decimalfractionpersecondQuantity.Value, DecimalFractionsPerSecondTolerance);
            Assert.Equal(RatioChangeRateUnit.DecimalFractionPerSecond, decimalfractionpersecondQuantity.Unit);

            var percentpersecondQuantity = decimalfractionpersecond.ToUnit(RatioChangeRateUnit.PercentPerSecond);
            AssertEx.EqualTolerance(PercentsPerSecondInOneDecimalFractionPerSecond, (double)percentpersecondQuantity.Value, PercentsPerSecondTolerance);
            Assert.Equal(RatioChangeRateUnit.PercentPerSecond, percentpersecondQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(1, RatioChangeRate.FromDecimalFractionsPerSecond(decimalfractionpersecond.DecimalFractionsPerSecond).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(1, RatioChangeRate.FromPercentsPerSecond(decimalfractionpersecond.PercentsPerSecond).DecimalFractionsPerSecond, PercentsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RatioChangeRate v = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RatioChangeRate.FromDecimalFractionsPerSecond(3)-v).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RatioChangeRate.FromDecimalFractionsPerSecond(10)/5).DecimalFractionsPerSecond, DecimalFractionsPerSecondTolerance);
            AssertEx.EqualTolerance(2, RatioChangeRate.FromDecimalFractionsPerSecond(10)/RatioChangeRate.FromDecimalFractionsPerSecond(5), DecimalFractionsPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RatioChangeRate oneDecimalFractionPerSecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            RatioChangeRate twoDecimalFractionsPerSecond = RatioChangeRate.FromDecimalFractionsPerSecond(2);

            Assert.True(oneDecimalFractionPerSecond < twoDecimalFractionsPerSecond);
            Assert.True(oneDecimalFractionPerSecond <= twoDecimalFractionsPerSecond);
            Assert.True(twoDecimalFractionsPerSecond > oneDecimalFractionPerSecond);
            Assert.True(twoDecimalFractionsPerSecond >= oneDecimalFractionPerSecond);

            Assert.False(oneDecimalFractionPerSecond > twoDecimalFractionsPerSecond);
            Assert.False(oneDecimalFractionPerSecond >= twoDecimalFractionsPerSecond);
            Assert.False(twoDecimalFractionsPerSecond < oneDecimalFractionPerSecond);
            Assert.False(twoDecimalFractionsPerSecond <= oneDecimalFractionPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.Equal(0, decimalfractionpersecond.CompareTo(decimalfractionpersecond));
            Assert.True(decimalfractionpersecond.CompareTo(RatioChangeRate.Zero) > 0);
            Assert.True(RatioChangeRate.Zero.CompareTo(decimalfractionpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.Throws<ArgumentException>(() => decimalfractionpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => decimalfractionpersecond.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            var b = RatioChangeRate.FromDecimalFractionsPerSecond(2);

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
            var a = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            var b = RatioChangeRate.FromDecimalFractionsPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.True(v.Equals(RatioChangeRate.FromDecimalFractionsPerSecond(1), DecimalFractionsPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RatioChangeRate.Zero, DecimalFractionsPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.False(decimalfractionpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RatioChangeRate decimalfractionpersecond = RatioChangeRate.FromDecimalFractionsPerSecond(1);
            Assert.False(decimalfractionpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RatioChangeRateUnit.Undefined, RatioChangeRate.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RatioChangeRateUnit)).Cast<RatioChangeRateUnit>();
            foreach(var unit in units)
            {
                if(unit == RatioChangeRateUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RatioChangeRate.BaseDimensions is null);
        }
    }
}
