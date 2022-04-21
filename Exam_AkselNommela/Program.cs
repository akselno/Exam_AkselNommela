using System;

namespace Exam_AkselNommela
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectionResultAnalyzer analyzer = new ElectionResultAnalyzer();
            /*
            analyzer.PrintMinCouncilMembers(); //1.

            Console.WriteLine("");

            analyzer.PrintMinAndMaxEVoterTurnoutRates(); //2.

            Console.WriteLine("");

            analyzer.PrintMinAndMaxPaperVoterTurnoutRates(); //3.

            Console.WriteLine("");

            analyzer.PrintMinAndMaxTotalVoterTurnoutRates(); //4.

            Console.WriteLine("");
            
            analyzer.InfoForASpecificRegion("lääne-viru"); //5.
            
            analyzer.PrintSummaryInfo(); //6.

            Console.WriteLine("");

            analyzer.PrintMinAndMaxEligibleVotersPercentages(); //7.

            Console.WriteLine("");
            */
            analyzer.PrintWhenElectionsAreHeld(1922); //8.
            
            Console.WriteLine("");

            analyzer.EligibilityCheckFor2021Elections("39410221419"); //9.

            Console.WriteLine("");

            analyzer.PrintUsername("JÜRGEN ROOSTE");                    //10.
            analyzer.PrintUsername("RAIMOND ERNST LEITARU");
            analyzer.PrintUsername("JOOSEP JÜRGENSON");
            analyzer.PrintUsername("KARL-MARTIN SINIJÄRV");
            analyzer.PrintUsername("MARJU LEETS-KÕIV");
            analyzer.PrintUsername("RUDOLF KASPER NARUSKI");
            analyzer.PrintUsername("ÜLO PRUUL");
            analyzer.PrintUsername("ANETTE MÄLETJÄRV");
            analyzer.PrintUsername("JÜRI KUUSKEMAA");
            analyzer.PrintUsername("TATJANA TŠERVOVA");
            analyzer.PrintUsername("ARVI KÄÄRD");
            analyzer.PrintUsername("KAROLINA EBBA ANNA ULLMAN");

            Console.WriteLine("");
            
            analyzer.PrintBiggestWinnersAndLosers(); //11.
            
            Console.WriteLine("");
            
            analyzer.PrintTotalKesklinnVotesForASpecificParty("reform"); //adv 1.
            analyzer.PrintTotalLasnamäeVotesForASpecificParty("reform");

            Console.WriteLine("");
            
            analyzer.PrintPartysBiggestWinnerAndLoserInKesklinn("reform"); //adv. 2.
            Console.WriteLine("");
            analyzer.PrintPartysBiggestWinnerAndLoserInLasnamäe("reform");

            Console.WriteLine("");

            analyzer.PrintCandidatesWhoGot0EOrPaperVotesInKesklinn(); //adv. 3.
            Console.WriteLine("");
            analyzer.PrintCandidatesWhoGot0EOrPaperVotesInLasnamäe(); 

            Console.WriteLine("");
            
            analyzer.PrintInfoForCandidatesWhoGotPersonalMandateAtKesklinn(); //adv. 4.
            Console.WriteLine("");
            analyzer.PrintInfoForCandidatesWhoGotPersonalMandateAtLasnamäe();
            
            analyzer.CreateAndSaveToFileUsernamesForAllKesklinnCandidates(); //adv. 5.
            analyzer.CreateAndSaveToFileUsernamesForAllLasnaCandidates();
        }
    }
}
