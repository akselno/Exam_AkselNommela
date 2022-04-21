using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exam_AkselNommela;

namespace Exam_Tests
{
    [TestClass]
    public class ElectionAnalyzerTests
    {
        public ElectionResultAnalyzer analyzer = new ElectionResultAnalyzer();

        [TestMethod]
        public void TestMinCouncilMembers_0_neg10000()
        {
            int result = analyzer.FindMinCouncilMembersNeeded(-10000);
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void TestMinCouncilMembers_25_50000()
        {
            int result = analyzer.FindMinCouncilMembersNeeded(50000);
            Assert.AreEqual(result, 25);
        }

        [TestMethod]
        public void TestMinCouncilMembers_7_0()
        {
            int result = analyzer.FindMinCouncilMembersNeeded(0);
            Assert.AreEqual(result, 7);
        }

        [TestMethod]
        public void TestMinCouncilMembers_79_1000000000()
        {
            int result = analyzer.FindMinCouncilMembersNeeded(1000000000);
            Assert.AreEqual(result, 79);
        }

        [TestMethod]
        public void TestName_aLeXaNdRa()
        {
            string result = analyzer.ValidateInputToCorrectFormat("aLeXaNdRa");
            Assert.AreEqual(result, "Alexandra");
        }

        [TestMethod]
        public void TestBirthday_39410221419()
        {
            string birthday = analyzer.FindBirthday("39410221419");
            Assert.AreEqual(birthday, "1994-10-22");
        }

        [TestMethod]
        public void TestBirthday_13850459283()
        {
            string birthday = analyzer.FindBirthday("13850459283");
            Assert.AreEqual(birthday, "1838-50-45");
        }

        [TestMethod]
        public void TestBirthday_99999999999()
        {
            string birthday = analyzer.FindBirthday("99999999999");
            Assert.AreEqual(birthday, "");
        }

        [TestMethod]
        public void TestVotingEligibility_39410221419()
        {
            bool[] result = analyzer.FindVotingAndCandidateEligibility("39410221419");
            Assert.IsTrue(result[0]);
        }

        [TestMethod]
        public void TestCandidacyEligibility_39410221419()
        {
            bool[] result = analyzer.FindVotingAndCandidateEligibility("39410221419");
            Assert.IsTrue(result[1]);
        }

        [TestMethod]
        public void TestVotingEligibility_50408248375()
        {
            bool[] result = analyzer.FindVotingAndCandidateEligibility("50408248375");
            Assert.IsTrue(result[0]);
        }

        [TestMethod]
        public void TestCandidacyEligibility_50408248375()
        {
            bool[] result = analyzer.FindVotingAndCandidateEligibility("50408248375");
            Assert.IsFalse(result[1]);
        }

        [TestMethod]
        public void TestVotingEligibility_61303248395()
        {
            bool[] result = analyzer.FindVotingAndCandidateEligibility("61303248395");
            Assert.IsFalse(result[0]);
        }

        [TestMethod]
        public void TestUsername_ÜlarÄgeÖömees()
        {
            string result = analyzer.CreateUsername("ÜlAr-ÄgE ÖömEeS");
            Assert.AreEqual(result, "ularag.oomees");
        }

        [TestMethod]
        public void TestUsername_ÜlleÕieÖöbik_specialChars()
        {
            string result = analyzer.CreateUsername("Ülle-Õie Ööbik");
            Assert.AreEqual(result, "ulleoi.oobik");
        }

        [TestMethod]
        public void TestUsername_AkselNõmmmela_noSpace()
        {
            string result = analyzer.CreateUsername("AkselNõmmela");
            Assert.AreEqual(result, "akseln");
        }

        [TestMethod]
        public void TestUsername_SpecialChars_noSpace()
        {
            string result = analyzer.CreateUsername("/ä%Ö)ö*Ä(ü$Õ^õ%Ü~");
            Assert.AreEqual(result, "aooauo");
        }

        [TestMethod]
        public void TestUsername_CrazyName()
        {
            string result = analyzer.CreateUsername("Tö Ä Ü Õ Ig Chaosang");
            Assert.AreEqual(result, "toauoi.chaosa");
        }

        [TestMethod]
        public void TestInputFormatForRegions_tAlLiNn()
        {
            string result = analyzer.ValidateInputToCorrectFormat("tAlLiNn");
            Assert.AreEqual(result, "Tallinn");
        }

        [TestMethod]
        public void TestInputFormatForRegions_LääneViru()
        {
            string result = analyzer.ValidateInputToCorrectFormat("lääne-viru maakond");
            Assert.AreEqual(result, "Lääne-Viru maakond");
        }

        [TestMethod]
        public void TestInputFormatForRegions_IdaViru()
        {
            string result = analyzer.ValidateInputToCorrectFormat("ida-viru maakond");
            Assert.AreEqual(result, "Ida-Viru maakond");
        }

        [TestMethod]
        public void TestRemovingSpecialChars()
        {
            string result = analyzer.RemoveSpecialCharsFromName("ö-y#Ü/*'k,.r:a$j|ö}ä&ÜÕ");
            Assert.AreEqual(result, "oyukrajoauo");
        }
    }
}
