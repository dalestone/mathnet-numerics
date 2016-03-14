// <copyright file="GammaTests.cs" company="Math.NET">
// Math.NET Numerics, part of the Math.NET Project
// http://numerics.mathdotnet.com
// http://github.com/mathnet/mathnet-numerics
//
// Copyright (c) 2009-2016 Math.NET
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// </copyright>

extern alias NUnitFramework;

using System;
using NUnitFramework.NUnit.Framework;

namespace MathNet.Numerics.UnitTests.SpecialFunctionsTests
{
    /// <summary>
    /// Gamma functions tests.
    /// </summary>
    [TestFixture, Category("Functions")]
    public class GammaTests
    {
        [TestCase(Double.NaN, Double.NaN, 14)]
        [TestCase(1.000001e-35, 9.9999900000099999900000099999899999522784235098567139293e+34, 14)]
        [TestCase(1.000001e-10, 9.99998999943278432519738283781280989934496494539074049002e+9, 14)]
        [TestCase(1.000001e-5, 99999.32279432557746387178953902739303931424932435387031653234, 14)]
        [TestCase(1.000001e-2, 99.43248512896257405886134437203369035261893114349805309870831, 14)]
        [TestCase(-4.8, -0.06242336135475955314181664931547009890495158793105543559676, 12)]
        [TestCase(-1.5, 2.363271801207354703064223311121526910396732608163182837618410, 13)]
        [TestCase(-0.5, -3.54490770181103205459633496668229036559509891224477425642761, 13)]
        [TestCase(1.0e-5 + 1.0e-16, 99999.42279322556767360213300482199406241771308740302819426480, 10)]
        [TestCase(0.1, 9.513507698668731836292487177265402192550578626088377343050000, 13)]
        [TestCase(1.0 - 1.0e-14, 1.000000000000005772156649015427511664653698987042926067639529, 15)]
        [TestCase(1.0, 1.0, 15)]
        [TestCase(1.0 + 1.0e-14, 0.99999999999999422784335098477029953441189552403615306268023, 14)]
        [TestCase(1.5, 0.886226925452758013649083741670572591398774728061193564106903, 13)]
        [TestCase(Constants.Pi/2, 0.890560890381539328010659635359121005933541962884758999762766, 14)]
        [TestCase(2.0, 1.0, 16)]
        [TestCase(2.5, 1.329340388179137020473625612505858887098162092091790346160355, 14)]
        [TestCase(3.0, 2.0, 13)]
        [TestCase(Constants.Pi, 2.288037795340032417959588909060233922889688153356222441199380, 13)]
        [TestCase(3.5, 3.323350970447842551184064031264647217745405230229475865400889, 14)]
        [TestCase(4.0, 6.0, 13)]
        [TestCase(4.5, 11.63172839656744892914422410942626526210891830580316552890311, 13)]
        [TestCase(5.0 - 1.0e-14, 23.99999999999963853175957637087420162718107213574617032780374, 14)]
        [TestCase(5.0, 24.0, 13)]
        [TestCase(5.0 + 1.0e-14, 24.00000000000036146824042363510111050137786752408660789873592, 13)]
        [TestCase(5.5, 52.34277778455352018114900849241819367949013237611424488006401, 13)]
        [TestCase(10.1, 454760.7514415859508673358368319076190405047458218916492282448, 12)]
        [TestCase(150 + 1.0e-12, 3.8089226376496421386707466577615064443807882167327097140e+260, 12)]
        public void Gamma(double z, double expected, int decimalPlaces)
        {
            AssertHelpers.AlmostEqualRelative(expected, SpecialFunctions.Gamma(z), decimalPlaces);
        }

        [TestCase(Double.NaN, Double.NaN, 14)]
        [TestCase(1.000001e-35, 80.59047725479209894029636783061921392709972287131139201585211, 16)]
        [TestCase(1.000001e-10, 23.02584992988323521564308637407936081168344192865285883337793, 15)]
        [TestCase(1.000001e-5, 11.51291869289055371493077240324332039045238086972508869965363, 15)]
        [TestCase(1.000001e-2, 4.599478872433667224554543378460164306444416156144779542513592, 16)]
        [TestCase(0.1, 2.252712651734205959869701646368495118615627222294953765041739, 14)]
        [TestCase(1.0 - 1.0e-14, 5.772156649015410852768463312546533565566459794933360600e-15, 0)]
        [TestCase(1.0, 0.0, 14)]
        [TestCase(1.0 + 1.0e-14, -5.77215664901524635936177848990288632404978978079827014e-15, 0)]
        [TestCase(1.5, -0.12078223763524522234551844578164721225185272790259946836386, 13)]
        [TestCase(Constants.Pi/2, -0.11590380084550241329912089415904874214542604767006895, 13)]
        [TestCase(2.0, 0.0, 14)]
        [TestCase(2.5, 0.284682870472919159632494669682701924320137695559894729250145, 13)]
        [TestCase(3.0, 0.693147180559945309417232121458176568075500134360255254120680, 13)]
        [TestCase(Constants.Pi, 0.82769459232343710152957855845235995115350173412073715, 13)]
        [TestCase(3.5, 1.200973602347074224816021881450712995770238915468157197042113, 14)]
        [TestCase(4.0, 1.791759469228055000812477358380702272722990692183004705855374, 14)]
        [TestCase(4.5, 2.453736570842442220504142503435716157331823510689763131380823, 13)]
        [TestCase(5.0 - 1.0e-14, 3.178053830347930558470257283303394288448414225994179545985931, 14)]
        [TestCase(5.0, 3.178053830347945619646941601297055408873990960903515214096734, 14)]
        [TestCase(5.0 + 1.0e-14, 3.178053830347960680823625919312848824873279228348981287761046, 13)]
        [TestCase(5.5, 3.957813967618716293877400855822590998551304491975006780729532, 14)]
        [TestCase(10.1, 13.02752673863323795851370097886835481188051062306253294740504, 14)]
        [TestCase(150 + 1.0e-12, 600.0094705553324354062157737572509902987070089159051628001813, 13)]
        [TestCase(1.001e+7, 1.51342135323817913130119829455205139905331697084416059779e+8, 13)]
        public void GammaLn(double x, double expected, int decimalPlaces)
        {
            AssertHelpers.AlmostEqualRelative(expected, SpecialFunctions.GammaLn(x), decimalPlaces);
        }

        /// <summary>
        /// Gamma lower regularized.
        /// </summary>
        [TestCase(double.NaN, Double.NaN, Double.NaN, 14)]
        [TestCase(0.1, 1.0, 0.97587265627367222115949155252812057714751052498477013, 13)]
        [TestCase(0.1, 2.0, 0.99432617602018847196075251078067514034772764693462125, 13)]
        [TestCase(0.1, 8.0, 0.99999507519205198048686442150578226823401842046310854, 13)]
        [TestCase(1.5, 1.0, 0.42759329552912016600095238564127189392715996802703368, 13)]
        [TestCase(1.5, 2.0, 0.73853587005088937779717792402407879809718939080920993, 13)]
        [TestCase(1.5, 8.0, 0.99886601571021467734329986257903021041757398191304284, 13)]
        [TestCase(2.5, 1.0, 0.15085496391539036377410688601371365034788861473418704, 13)]
        [TestCase(2.5, 2.0, 0.45058404864721976739416885516693969548484517509263197, 13)]
        [TestCase(2.5, 8.0, 0.99315592607757956900093935107222761316136944145439676, 13)]
        [TestCase(5.5, 1.0, 0.0015041182825838038421585211353488839717739161316985392, 13)]
        [TestCase(5.5, 2.0, 0.030082976121226050615171484772387355162056796585883967, 13)]
        [TestCase(5.5, 8.0, 0.85886911973294184646060071855669224657735916933487681, 13)]
        [TestCase(100, 0.5, 0.0, 14)]
        [TestCase(100, 1.5, 0.0, 14)]
        [TestCase(100, 90, 0.1582209891864301681049696996709105316998233457433473, 12)]
        [TestCase(100, 100, 0.5132987982791486648573142565640291634709251499279450, 12)]
        [TestCase(100, 110, 0.8417213299399129061982996209829688531933500308658222, 12)]
        [TestCase(100, 200, 1.0, 14)]
        [TestCase(500, 0.5, 0.0, 14)]
        [TestCase(500, 1.5, 0.0, 14)]
        [TestCase(500, 200, 0.0, 14)]
        [TestCase(500, 450, 0.0107172380912897415573958770655204965434869949241480, 12)]
        [TestCase(500, 500, 0.5059471461707603580470479574412058032802735425634263, 12)]
        [TestCase(500, 550, 0.9853855918737048059548470006900844665580616318702748, 12)]
        [TestCase(500, 700, 1.0, 14)]
        [TestCase(1000, 10000, 1.0, 14)]
        [TestCase(1e+50, 1e+48, 0.0, 14)]
        [TestCase(1e+50, 1e+52, 1.0, 14)]
        public void GammaLowerRegularized(double a, double x, double y, int digits)
        {
            AssertHelpers.AlmostEqualRelative(y, SpecialFunctions.GammaLowerRegularized(a, x), digits);
        }

        /// <summary>
        /// Gamma lower regularized inverse.
        /// </summary>
        [TestCase(double.NaN, Double.NaN, Double.NaN, 14)]
        [TestCase(0.1, 1.0, 0.97587265627367222115949155252812057714751052498477013, 13)]
        [TestCase(0.1, 2.0, 0.99432617602018847196075251078067514034772764693462125, 13)]
        [TestCase(0.1, 8.0, 0.99999507519205198048686442150578226823401842046310854, 10)]
        [TestCase(1.5, 1.0, 0.42759329552912016600095238564127189392715996802703368, 13)]
        [TestCase(1.5, 2.0, 0.73853587005088937779717792402407879809718939080920993, 13)]
        [TestCase(1.5, 8.0, 0.99886601571021467734329986257903021041757398191304284, 13)]
        [TestCase(2.5, 1.0, 0.15085496391539036377410688601371365034788861473418704, 13)]
        [TestCase(2.5, 2.0, 0.45058404864721976739416885516693969548484517509263197, 13)]
        [TestCase(2.5, 8.0, 0.99315592607757956900093935107222761316136944145439676, 13)]
        [TestCase(5.5, 1.0, 0.0015041182825838038421585211353488839717739161316985392, 13)]
        [TestCase(5.5, 2.0, 0.030082976121226050615171484772387355162056796585883967, 13)]
        [TestCase(5.5, 8.0, 0.85886911973294184646060071855669224657735916933487681, 13)]
        [TestCase(100, 90, 0.1582209891864301681049696996709105316998233457433473, 12)]
        [TestCase(100, 100, 0.5132987982791486648573142565640291634709251499279450, 12)]
        [TestCase(100, 110, 0.8417213299399129061982996209829688531933500308658222, 12)]
        [TestCase(500, 450, 0.0107172380912897415573958770655204965434869949241480, 12)]
        [TestCase(500, 500, 0.5059471461707603580470479574412058032802735425634263, 12)]
        [TestCase(500, 550, 0.9853855918737048059548470006900844665580616318702748, 12)]
        public void GammaLowerRegularizedInv(double a, double x, double y, int digits)
        {
            AssertHelpers.AlmostEqualRelative(x, SpecialFunctions.GammaLowerRegularizedInv(a, y), digits);
        }

        /// <summary>
        /// Gamma lower incomplete.
        /// </summary>
        [TestCase(double.NaN, Double.NaN, Double.NaN)]
        [TestCase(0.1, 1.0, 9.2839720283798852469443229940217320532607158711056334)]
        [TestCase(0.1, 2.0, 9.4595297305559030536119885480983751098528458886962883)]
        [TestCase(0.1, 8.0, 9.5134608464704033372127589212547718314010339263844976)]
        [TestCase(1.5, 1.0, 0.37894469164098470380394366597039213790868855578083847)]
        [TestCase(1.5, 2.0, 0.65451037345177732033319477475056262302270310457635612)]
        [TestCase(1.5, 8.0, 0.88522195804210983776635107858848816480298923071075222)]
        [TestCase(2.5, 1.0, 0.20053759629003473411039172879412733941722170263949)]
        [TestCase(2.5, 2.0, 0.59897957413602228465664030130712917348327070206302442)]
        [TestCase(2.5, 8.0, 1.3202422842943799358198434659248530581833764879301293)]
        [TestCase(5.5, 1.0, 0.078729729026968321691794205337720556329618007004848672)]
        [TestCase(5.5, 2.0, 1.5746265342113649473739798668921124454837064926448459)]
        [TestCase(5.5, 8.0, 44.955595480196465884619737757794960132425035578313584)]
        public void GammaLowerIncomplete(double a, double x, double f)
        {
            AssertHelpers.AlmostEqualRelative(f, SpecialFunctions.GammaLowerIncomplete(a, x), 13);
        }

        /// <summary>
        /// Gamma upper regularized.
        /// </summary>
        [TestCase(double.NaN, Double.NaN, Double.NaN, 14)]
        [TestCase(0.1, 1.0, 0.0241273437263277773829694356333550393309597428392044, 13)]
        [TestCase(0.1, 2.0, 0.0056738239798115280392474892193248596522723530653781, 13)]
        [TestCase(0.1, 8.0, 0.0000049248079480195131355784942177317659815795368919702, 13)]
        [TestCase(1.5, 1.0, 0.57240670447087983399904761435872810607284003197297, 13)]
        [TestCase(1.5, 2.0, 0.26146412994911062220282207597592120190281060919079, 13)]
        [TestCase(1.5, 8.0, 0.0011339842897853226567001374209697895824260180869567, 13)]
        [TestCase(2.5, 1.0, 0.84914503608460963622589311398628634965211138526581, 13)]
        [TestCase(2.5, 2.0, 0.54941595135278023260583114483306030451515482490737, 13)]
        [TestCase(2.5, 8.0, 0.0068440739224204309990606489277723868386305585456026, 13)]
        [TestCase(5.5, 1.0, 0.9984958817174161961578414788646511160282260838683, 13)]
        [TestCase(5.5, 2.0, 0.96991702387877394938482851522761264483794320341412, 13)]
        [TestCase(5.5, 8.0, 0.14113088026705815353939928144330775342264083066512, 13)]
        [TestCase(100, 0.5, 1.0, 14)]
        [TestCase(100, 1.5, 1.0, 14)]
        [TestCase(100, 90, 0.8417790108135698318950303003290894683001766542566526, 12)]
        [TestCase(100, 100, 0.4867012017208513351426857434359708365290748500720549, 12)]
        [TestCase(100, 110, 0.1582786700600870938017003790170311468066499691341777, 12)]
        [TestCase(100, 200, 0.0, 14)]
        [TestCase(500, 0.5, 1.0, 14)]
        [TestCase(500, 1.5, 1.0, 14)]
        [TestCase(500, 200, 1.0, 14)]
        [TestCase(500, 450, 0.9892827619087102584426041229344795034565130050758519, 12)]
        [TestCase(500, 500, 0.4940528538292396419529520425587941967197264574365736, 12)]
        [TestCase(500, 550, 0.0146144081262951940451529993099155334419383681297251, 12)]
        [TestCase(500, 700, 0.0, 14)]
        [TestCase(1000, 10000, 0.0, 14)]
        [TestCase(1e+50, 1e+48, 1.0, 14)]
        [TestCase(1e+50, 1e+52, 0.0, 14)]
        public void GammaUpperRegularized(double a, double x, double f, int digits)
        {
            AssertHelpers.AlmostEqualRelative(f, SpecialFunctions.GammaUpperRegularized(a, x), digits);
        }

        /// <summary>
        /// Gamma upper incomplete.
        /// </summary>
        [TestCase(double.NaN, Double.NaN, Double.NaN)]
        [TestCase(0.1, 1.0, 0.2295356702888460382790772147651768201739736396141314)]
        [TestCase(0.1, 2.0, 0.053977968112828232195991347726857391060870217694027)]
        [TestCase(0.1, 8.0, 0.000046852198327948595220974570460669512682180005810156)]
        [TestCase(1.5, 1.0, 0.50728223381177330984514007570018045349008617228036)]
        [TestCase(1.5, 2.0, 0.23171655200098069331588896692000996837607162348484)]
        [TestCase(1.5, 8.0, 0.0010049674106481758827326630820844265957854973504417)]
        [TestCase(2.5, 1.0, 1.1288027918891022863632338837117315476809403894523)]
        [TestCase(2.5, 2.0, 0.73036081404311473581698531119872971361489139002877)]
        [TestCase(2.5, 8.0, 0.0090981038847570846537821465810058289147856041616617)]
        [TestCase(5.5, 1.0, 52.264048055526551859457214287080473123160514369109)]
        [TestCase(5.5, 2.0, 50.768151250342155233775028625526081234006425883469)]
        [TestCase(5.5, 8.0, 7.3871823043570542965292707346232335470650967978006)]
        public void GammaUpperIncomplete(double a, double x, double f)
        {
            AssertHelpers.AlmostEqualRelative(f, SpecialFunctions.GammaUpperIncomplete(a, x), 13);
        }

        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(0.0, 1.0, 0.0)]
        [TestCase(0.0, 2.0, 0.0)]
        public void GammaUpperIncomplete_SpecialCases(double a, double x, double f)
        {
            double actual = SpecialFunctions.GammaUpperRegularized(a, x);
            AssertHelpers.AlmostEqualRelative(f, actual, 13);
        }

        [TestCase(0.0, 0.0, 1.0)]
        [TestCase(0.0, 1.0, 1.0)]
        [TestCase(0.0, 2.0, 1.0)]
        public void GammaLowerIncomplete_SpecialCases(double a, double x, double f)
        {
            double actual = SpecialFunctions.GammaLowerRegularized(a, x);
            AssertHelpers.AlmostEqualRelative(f, actual, 13);
        }

        [TestCase(0.0, 0.0, 1.0)]
        [TestCase(0.0, 1.0, 1.0)]
        [TestCase(0.0, 2.0, 1.0)]
        public void GammaIncompleteRegularized_CheckSum(double a, double x, double f)
        {
            double actualLower = SpecialFunctions.GammaLowerRegularized(a, x);
            double actualUpper = SpecialFunctions.GammaUpperRegularized(a, x);
            AssertHelpers.AlmostEqualRelative(f, actualLower + actualUpper, 13);
        }

    }
}
