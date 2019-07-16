using System;
using System.IO;
using Xunit;

namespace CodingChallenges.Tests.PokemonGo
{
	public class PokemonGoTests
	{
		[Fact]
		public void Test1()
		{
			var input = "6 553220 83" + Environment.NewLine
+ "70742 84381" + Environment.NewLine
+ "-90129 84381" + Environment.NewLine
+ "34776 84381" + Environment.NewLine
+ "34776 38382" + Environment.NewLine
+ "-99047 38382" + Environment.NewLine
+ "-11536 38382" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("553088,36", output);
		}

		[Fact]
		public void Test2()
		{
			var input = "7 279641 97" + Environment.NewLine
+ "-67820 -36264" + Environment.NewLine
+ "-67820 -35684" + Environment.NewLine
+ "-67820 -13730" + Environment.NewLine
+ "-67820 3765" + Environment.NewLine
+ "-88060 3765" + Environment.NewLine
+ "-88060 94403" + Environment.NewLine
+ "40452 94403" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("279419,00", output);
		}

		[Fact]
		public void Test3()
		{
			var input = "5 197965 65" + Environment.NewLine
+ "-32827 86341" + Environment.NewLine
+ "-32827 86717" + Environment.NewLine
+ "-32827 -25090" + Environment.NewLine
+ "42724 -25090" + Environment.NewLine
+ "42724 -35285" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("197911,19", output);
		}

		[Fact]
		public void Test4()
		{
			var input = "4 125278 81" + Environment.NewLine
+ "5674 -85769" + Environment.NewLine
+ "5674 -70378" + Environment.NewLine
+ "-60338 -70378" + Environment.NewLine
+ "-60338 -26571" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("125209,01", output);
		}

		[Fact]
		public void Test5()
		{
			var input = "4 333600 73" + Environment.NewLine
+ "-59250 48434" + Environment.NewLine
+ "-59250 94813" + Environment.NewLine
+ "-59250 -73837" + Environment.NewLine
+ "59194 -73837" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("333473,00", output);
		}

		[Fact]
		public void Test6()
		{
			var input = "9 340283 18" + Environment.NewLine
+ "66366 48495" + Environment.NewLine
+ "94484 48495" + Environment.NewLine
+ "94484 -131" + Environment.NewLine
+ "94047 -131" + Environment.NewLine
+ "88111 -131" + Environment.NewLine
+ "88111 899" + Environment.NewLine
+ "88111 24695" + Environment.NewLine
+ "88111 81097" + Environment.NewLine
+ "88111 -94761" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("340203,00", output);
		}

		[Fact]
		public void Test7()
		{
			var input = "10 608252 48" + Environment.NewLine
+ "-59551 -22834" + Environment.NewLine
+ "4378 -22834" + Environment.NewLine
+ "4378 91438" + Environment.NewLine
+ "-19596 91438" + Environment.NewLine
+ "44789 91438" + Environment.NewLine
+ "81498 91438" + Environment.NewLine
+ "-89197 91438" + Environment.NewLine
+ "-89197 68757" + Environment.NewLine
+ "-47241 68757" + Environment.NewLine
+ "22291 68757" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("608126,96", output);
		}

		[Fact]
		public void Test8()
		{
			var input = "10 577730 69" + Environment.NewLine
+ "-7144 98051" + Environment.NewLine
+ "-7144 -92936" + Environment.NewLine
+ "-7144 61803" + Environment.NewLine
+ "-7144 54218" + Environment.NewLine
+ "-28076 54218" + Environment.NewLine
+ "-28076 92302" + Environment.NewLine
+ "-47147 92302" + Environment.NewLine
+ "-47147 98972" + Environment.NewLine
+ "62553 98972" + Environment.NewLine
+ "32690 98972" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("577609,55", output);
		}

		[Fact]
		public void Test9()
		{
			var input = "6 479490 62" + Environment.NewLine
+ "99015 -27144" + Environment.NewLine
+ "99015 -81552" + Environment.NewLine
+ "99015 39339" + Environment.NewLine
+ "-94795 39339" + Environment.NewLine
+ "-11653 39339" + Environment.NewLine
+ "-38756 39339" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("479354,00", output);
		}

		[Fact]
		public void Test10()
		{
			var input = "8 263618 6" + Environment.NewLine
+ "25413 -30490" + Environment.NewLine
+ "29625 -30490" + Environment.NewLine
+ "29625 -22118" + Environment.NewLine
+ "29625 -14987" + Environment.NewLine
+ "29625 45867" + Environment.NewLine
+ "48801 45867" + Environment.NewLine
+ "89045 45867" + Environment.NewLine
+ "89045 -77747" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("263603,00", output);
		}

		[Fact]
		public void Test11()
		{
			var input = "9 549962 47" + Environment.NewLine
+ "27056 26724" + Environment.NewLine
+ "65661 26724" + Environment.NewLine
+ "-82305 26724" + Environment.NewLine
+ "-82305 -89876" + Environment.NewLine
+ "-82305 -37419" + Environment.NewLine
+ "-75349 -37419" + Environment.NewLine
+ "95119 -37419" + Environment.NewLine
+ "88349 -37419" + Environment.NewLine
+ "88349 -47475" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("549867,08", output);
		}

		[Fact]
		public void Test12()
		{
			var input = "9 314123 34" + Environment.NewLine
+ "28979 -19627" + Environment.NewLine
+ "28979 46261" + Environment.NewLine
+ "-65605 46261" + Environment.NewLine
+ "-65605 32652" + Environment.NewLine
+ "-65605 66194" + Environment.NewLine
+ "-39021 66194" + Environment.NewLine
+ "-7046 66194" + Environment.NewLine
+ "14605 66194" + Environment.NewLine
+ "14605 92450" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("314073,17", output);
		}

		[Fact]
		public void Test13()
		{
			var input = "6 263623 10" + Environment.NewLine
+ "27371 -91302" + Environment.NewLine
+ "27332 -91302" + Environment.NewLine
+ "27332 -24692" + Environment.NewLine
+ "27332 91205" + Environment.NewLine
+ "27332 22395" + Environment.NewLine
+ "15095 22395" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("263593,00", output);
		}

		[Fact]
		public void Test14()
		{
			var input = "3 210440 72" + Environment.NewLine
+ "27738 86758" + Environment.NewLine
+ "-41175 86758" + Environment.NewLine
+ "-41175 -54734" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("210397,41", output);
		}

		[Fact]
		public void Test15()
		{
			var input = "6 330424 52" + Environment.NewLine
+ "-48480 -78777" + Environment.NewLine
+ "-48480 20346" + Environment.NewLine
+ "-48480 -50153" + Environment.NewLine
+ "13546 -50153" + Environment.NewLine
+ "13546 35482" + Environment.NewLine
+ "13546 48591" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("330370,00", output);
		}

		[Fact]
		public void Test16()
		{
			var input = "6 320759 11" + Environment.NewLine
+ "87107 -29781" + Environment.NewLine
+ "62112 -29781" + Environment.NewLine
+ "-53872 -29781" + Environment.NewLine
+ "-32728 -29781" + Environment.NewLine
+ "-32728 12199" + Environment.NewLine
+ "83898 12199" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("320729,00", output);
		}

		[Fact]
		public void Test17()
		{
			var input = "10 729071 58" + Environment.NewLine
+ "83650 -31762" + Environment.NewLine
+ "83650 60913" + Environment.NewLine
+ "-47240 60913" + Environment.NewLine
+ "77037 60913" + Environment.NewLine
+ "48549 60913" + Environment.NewLine
+ "41596 60913" + Environment.NewLine
+ "41596 -44379" + Environment.NewLine
+ "41596 -64228" + Environment.NewLine
+ "41596 22174" + Environment.NewLine
+ "-92616 22174" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("728947,27", output);
		}

		[Fact]
		public void Test18()
		{
			var input = "5 216352 43" + Environment.NewLine
+ "-27490 56319" + Environment.NewLine
+ "-31864 56319" + Environment.NewLine
+ "53677 56319" + Environment.NewLine
+ "86889 56319" + Environment.NewLine
+ "86889 -36902" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("216319,41", output);
		}

		[Fact]
		public void Test19()
		{
			var input = "9 463654 18" + Environment.NewLine
+ "17272 -5615" + Environment.NewLine
+ "-31473 -5615" + Environment.NewLine
+ "-31473 98569" + Environment.NewLine
+ "-34793 98569" + Environment.NewLine
+ "32097 98569" + Environment.NewLine
+ "-1460 98569" + Environment.NewLine
+ "38816 98569" + Environment.NewLine
+ "35537 98569" + Environment.NewLine
+ "35537 -64763" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("463581,09", output);
		}

		[Fact]
		public void Test20()
		{
			var input = "6 344028 72" + Environment.NewLine
+ "15247 53443" + Environment.NewLine
+ "18749 53443" + Environment.NewLine
+ "18749 -24732" + Environment.NewLine
+ "18749 -96128" + Environment.NewLine
+ "-2985 -96128" + Environment.NewLine
+ "-2985 73022" + Environment.NewLine
+ "";
			var output = new Problems.PokemonGo.Solution().Solve(input);
			Assert.Equal("343947,80", output);
		}
	}
}
