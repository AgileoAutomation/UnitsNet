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
    /// Test of DynamicViscosity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class DynamicViscosityTestsBase
    {
        protected abstract double CentipoiseInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double MicropascalSecondsInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double MillipascalSecondsInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double NewtonSecondsPerMeterSquaredInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double PascalSecondsInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double PoiseInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double PoundsForceSecondPerSquareFootInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double PoundsForceSecondPerSquareInchInOneNewtonSecondPerMeterSquared { get; }
        protected abstract double ReynsInOneNewtonSecondPerMeterSquared { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentipoiseTolerance { get { return 1e-5; } }
        protected virtual double MicropascalSecondsTolerance { get { return 1e-5; } }
        protected virtual double MillipascalSecondsTolerance { get { return 1e-5; } }
        protected virtual double NewtonSecondsPerMeterSquaredTolerance { get { return 1e-5; } }
        protected virtual double PascalSecondsTolerance { get { return 1e-5; } }
        protected virtual double PoiseTolerance { get { return 1e-5; } }
        protected virtual double PoundsForceSecondPerSquareFootTolerance { get { return 1e-5; } }
        protected virtual double PoundsForceSecondPerSquareInchTolerance { get { return 1e-5; } }
        protected virtual double ReynsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new DynamicViscosity((double)0.0, DynamicViscosityUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_CreateQuantityAndAffectInfinityValue()
        {
            var positiveInfinityQuantity = new DynamicViscosity(double.PositiveInfinity, DynamicViscosityUnit.NewtonSecondPerMeterSquared);
            var negativeInfinityQuantity = new DynamicViscosity(double.NegativeInfinity, DynamicViscosityUnit.NewtonSecondPerMeterSquared);

            Assert.True(double.IsPositiveInfinity(positiveInfinityQuantity.Value));
            Assert.True(double.IsNegativeInfinity(negativeInfinityQuantity.Value));
        }

        [Fact]
        public void Ctor_WithNaNValue_CreateQuantityAndAffectNaNValue()
        {
            var nanQuantity = new DynamicViscosity(double.NaN, DynamicViscosityUnit.NewtonSecondPerMeterSquared);
            Assert.True(double.IsNaN(nanQuantity.Value));
        }

        [Fact]
        public void NewtonSecondPerMeterSquaredToDynamicViscosityUnits()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(CentipoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.Centipoise, CentipoiseTolerance);
            AssertEx.EqualTolerance(MicropascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.MicropascalSeconds, MicropascalSecondsTolerance);
            AssertEx.EqualTolerance(MillipascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.MillipascalSeconds, MillipascalSecondsTolerance);
            AssertEx.EqualTolerance(NewtonSecondsPerMeterSquaredInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(PascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.PascalSeconds, PascalSecondsTolerance);
            AssertEx.EqualTolerance(PoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.Poise, PoiseTolerance);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareFootInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.PoundsForceSecondPerSquareFoot, PoundsForceSecondPerSquareFootTolerance);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareInchInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.PoundsForceSecondPerSquareInch, PoundsForceSecondPerSquareInchTolerance);
            AssertEx.EqualTolerance(ReynsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.Reyns, ReynsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.Centipoise).Centipoise, CentipoiseTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.MicropascalSecond).MicropascalSeconds, MicropascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.MillipascalSecond).MillipascalSeconds, MillipascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.NewtonSecondPerMeterSquared).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.PascalSecond).PascalSeconds, PascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.Poise).Poise, PoiseTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.PoundForceSecondPerSquareFoot).PoundsForceSecondPerSquareFoot, PoundsForceSecondPerSquareFootTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.PoundForceSecondPerSquareInch).PoundsForceSecondPerSquareInch, PoundsForceSecondPerSquareInchTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.From(1, DynamicViscosityUnit.Reyn).Reyns, ReynsTolerance);
        }

        [Fact]
        public void FromNewtonSecondsPerMeterSquared_WithInfinityValue_CreateQuantityAndAffectInfinityValue()
        {
            var positiveInfinityQuantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(double.PositiveInfinity);
            var negativeInfinityQuantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(double.NegativeInfinity);

            Assert.True(double.IsPositiveInfinity(positiveInfinityQuantity.Value));
            Assert.True(double.IsNegativeInfinity(negativeInfinityQuantity.Value));
        }

        [Fact]
        public void FromNewtonSecondsPerMeterSquared_WithNanValue_CreateQuantityAndAffectNaNValue()
        {
            var nanQuantity = DynamicViscosity.FromNewtonSecondsPerMeterSquared(double.NaN);
            Assert.True(double.IsNaN(nanQuantity.Value));
        }

        [Fact]
        public void As()
        {
            var newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(CentipoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.Centipoise), CentipoiseTolerance);
            AssertEx.EqualTolerance(MicropascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.MicropascalSecond), MicropascalSecondsTolerance);
            AssertEx.EqualTolerance(MillipascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.MillipascalSecond), MillipascalSecondsTolerance);
            AssertEx.EqualTolerance(NewtonSecondsPerMeterSquaredInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.NewtonSecondPerMeterSquared), NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(PascalSecondsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.PascalSecond), PascalSecondsTolerance);
            AssertEx.EqualTolerance(PoiseInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.Poise), PoiseTolerance);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareFootInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.PoundForceSecondPerSquareFoot), PoundsForceSecondPerSquareFootTolerance);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareInchInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.PoundForceSecondPerSquareInch), PoundsForceSecondPerSquareInchTolerance);
            AssertEx.EqualTolerance(ReynsInOneNewtonSecondPerMeterSquared, newtonsecondpermetersquared.As(DynamicViscosityUnit.Reyn), ReynsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);

            var centipoiseQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.Centipoise);
            AssertEx.EqualTolerance(CentipoiseInOneNewtonSecondPerMeterSquared, (double)centipoiseQuantity.Value, CentipoiseTolerance);
            Assert.Equal(DynamicViscosityUnit.Centipoise, centipoiseQuantity.Unit);

            var micropascalsecondQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.MicropascalSecond);
            AssertEx.EqualTolerance(MicropascalSecondsInOneNewtonSecondPerMeterSquared, (double)micropascalsecondQuantity.Value, MicropascalSecondsTolerance);
            Assert.Equal(DynamicViscosityUnit.MicropascalSecond, micropascalsecondQuantity.Unit);

            var millipascalsecondQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.MillipascalSecond);
            AssertEx.EqualTolerance(MillipascalSecondsInOneNewtonSecondPerMeterSquared, (double)millipascalsecondQuantity.Value, MillipascalSecondsTolerance);
            Assert.Equal(DynamicViscosityUnit.MillipascalSecond, millipascalsecondQuantity.Unit);

            var newtonsecondpermetersquaredQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.NewtonSecondPerMeterSquared);
            AssertEx.EqualTolerance(NewtonSecondsPerMeterSquaredInOneNewtonSecondPerMeterSquared, (double)newtonsecondpermetersquaredQuantity.Value, NewtonSecondsPerMeterSquaredTolerance);
            Assert.Equal(DynamicViscosityUnit.NewtonSecondPerMeterSquared, newtonsecondpermetersquaredQuantity.Unit);

            var pascalsecondQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.PascalSecond);
            AssertEx.EqualTolerance(PascalSecondsInOneNewtonSecondPerMeterSquared, (double)pascalsecondQuantity.Value, PascalSecondsTolerance);
            Assert.Equal(DynamicViscosityUnit.PascalSecond, pascalsecondQuantity.Unit);

            var poiseQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.Poise);
            AssertEx.EqualTolerance(PoiseInOneNewtonSecondPerMeterSquared, (double)poiseQuantity.Value, PoiseTolerance);
            Assert.Equal(DynamicViscosityUnit.Poise, poiseQuantity.Unit);

            var poundforcesecondpersquarefootQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.PoundForceSecondPerSquareFoot);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareFootInOneNewtonSecondPerMeterSquared, (double)poundforcesecondpersquarefootQuantity.Value, PoundsForceSecondPerSquareFootTolerance);
            Assert.Equal(DynamicViscosityUnit.PoundForceSecondPerSquareFoot, poundforcesecondpersquarefootQuantity.Unit);

            var poundforcesecondpersquareinchQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.PoundForceSecondPerSquareInch);
            AssertEx.EqualTolerance(PoundsForceSecondPerSquareInchInOneNewtonSecondPerMeterSquared, (double)poundforcesecondpersquareinchQuantity.Value, PoundsForceSecondPerSquareInchTolerance);
            Assert.Equal(DynamicViscosityUnit.PoundForceSecondPerSquareInch, poundforcesecondpersquareinchQuantity.Unit);

            var reynQuantity = newtonsecondpermetersquared.ToUnit(DynamicViscosityUnit.Reyn);
            AssertEx.EqualTolerance(ReynsInOneNewtonSecondPerMeterSquared, (double)reynQuantity.Value, ReynsTolerance);
            Assert.Equal(DynamicViscosityUnit.Reyn, reynQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromCentipoise(newtonsecondpermetersquared.Centipoise).NewtonSecondsPerMeterSquared, CentipoiseTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromMicropascalSeconds(newtonsecondpermetersquared.MicropascalSeconds).NewtonSecondsPerMeterSquared, MicropascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromMillipascalSeconds(newtonsecondpermetersquared.MillipascalSeconds).NewtonSecondsPerMeterSquared, MillipascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromNewtonSecondsPerMeterSquared(newtonsecondpermetersquared.NewtonSecondsPerMeterSquared).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromPascalSeconds(newtonsecondpermetersquared.PascalSeconds).NewtonSecondsPerMeterSquared, PascalSecondsTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromPoise(newtonsecondpermetersquared.Poise).NewtonSecondsPerMeterSquared, PoiseTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromPoundsForceSecondPerSquareFoot(newtonsecondpermetersquared.PoundsForceSecondPerSquareFoot).NewtonSecondsPerMeterSquared, PoundsForceSecondPerSquareFootTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromPoundsForceSecondPerSquareInch(newtonsecondpermetersquared.PoundsForceSecondPerSquareInch).NewtonSecondsPerMeterSquared, PoundsForceSecondPerSquareInchTolerance);
            AssertEx.EqualTolerance(1, DynamicViscosity.FromReyns(newtonsecondpermetersquared.Reyns).NewtonSecondsPerMeterSquared, ReynsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            DynamicViscosity v = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            AssertEx.EqualTolerance(-1, -v.NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, (DynamicViscosity.FromNewtonSecondsPerMeterSquared(3)-v).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, (DynamicViscosity.FromNewtonSecondsPerMeterSquared(10)/5).NewtonSecondsPerMeterSquared, NewtonSecondsPerMeterSquaredTolerance);
            AssertEx.EqualTolerance(2, DynamicViscosity.FromNewtonSecondsPerMeterSquared(10)/DynamicViscosity.FromNewtonSecondsPerMeterSquared(5), NewtonSecondsPerMeterSquaredTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            DynamicViscosity oneNewtonSecondPerMeterSquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            DynamicViscosity twoNewtonSecondsPerMeterSquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(2);

            Assert.True(oneNewtonSecondPerMeterSquared < twoNewtonSecondsPerMeterSquared);
            Assert.True(oneNewtonSecondPerMeterSquared <= twoNewtonSecondsPerMeterSquared);
            Assert.True(twoNewtonSecondsPerMeterSquared > oneNewtonSecondPerMeterSquared);
            Assert.True(twoNewtonSecondsPerMeterSquared >= oneNewtonSecondPerMeterSquared);

            Assert.False(oneNewtonSecondPerMeterSquared > twoNewtonSecondsPerMeterSquared);
            Assert.False(oneNewtonSecondPerMeterSquared >= twoNewtonSecondsPerMeterSquared);
            Assert.False(twoNewtonSecondsPerMeterSquared < oneNewtonSecondPerMeterSquared);
            Assert.False(twoNewtonSecondsPerMeterSquared <= oneNewtonSecondPerMeterSquared);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.Equal(0, newtonsecondpermetersquared.CompareTo(newtonsecondpermetersquared));
            Assert.True(newtonsecondpermetersquared.CompareTo(DynamicViscosity.Zero) > 0);
            Assert.True(DynamicViscosity.Zero.CompareTo(newtonsecondpermetersquared) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.Throws<ArgumentException>(() => newtonsecondpermetersquared.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.Throws<ArgumentNullException>(() => newtonsecondpermetersquared.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            var b = DynamicViscosity.FromNewtonSecondsPerMeterSquared(2);

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
            var a = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            var b = DynamicViscosity.FromNewtonSecondsPerMeterSquared(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.True(v.Equals(DynamicViscosity.FromNewtonSecondsPerMeterSquared(1), NewtonSecondsPerMeterSquaredTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(DynamicViscosity.Zero, NewtonSecondsPerMeterSquaredTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.False(newtonsecondpermetersquared.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            DynamicViscosity newtonsecondpermetersquared = DynamicViscosity.FromNewtonSecondsPerMeterSquared(1);
            Assert.False(newtonsecondpermetersquared.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(DynamicViscosityUnit.Undefined, DynamicViscosity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(DynamicViscosityUnit)).Cast<DynamicViscosityUnit>();
            foreach(var unit in units)
            {
                if(unit == DynamicViscosityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(DynamicViscosity.BaseDimensions is null);
        }
    }
}
