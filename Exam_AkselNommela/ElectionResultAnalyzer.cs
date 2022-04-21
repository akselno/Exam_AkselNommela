using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exam_AkselNommela
{
    public class ElectionResultAnalyzer
    {
        private string _generalDataFileName = "generalData_2021.txt";
        private string _statisticsFileName = "statistika.txt";
        private string _tallinnKesklinnFileName = "tallinn_region2.txt";
        private string _tallinnLasnamäeFileName = "tallinn_region4.txt";
        private int _kesklinnQuota = 2610;
        private int _lasnaQuota = 2969;
        private List<string> _regionNamesList = new List<string>();
        private List<string> _paperVotersList = new List<string>();
        private List<string> _eVotersList = new List<string>();
        private List<string> _possibleVotersList = new List<string>();
        private List<string> _totalPopulationList = new List<string>();
        private List<string> _partyNamesList = new List<string>();
        private List<string> _forecastedResultsList = new List<string>();
        private List<string> _actualResultsList = new List<string>();
        private List<string> _usernamesList = new List<string>();
        private List<string> _isamaaList = new List<string>();
        private List<string> _isamaaCandidatesList = new List<string>();
        private List<string> _rohelisedList = new List<string>();
        private List<string> _rohelisedCandidatesList = new List<string>();
        private List<string> _vabaEestiList = new List<string>();
        private List<string> _vabaEestiCandidatesList = new List<string>();
        private List<string> _sotsidList = new List<string>();
        private List<string> _sotsidCandidatesList = new List<string>();
        private List<string> _kesikudList = new List<string>();
        private List<string> _kesikudCandidatesList = new List<string>();
        private List<string> _eesti200List = new List<string>();
        private List<string> _eesti200CandidatesList = new List<string>();
        private List<string> _narodnyiList = new List<string>();
        private List<string> _narodnyiCandidatesList = new List<string>();
        private List<string> _reformiList = new List<string>();
        private List<string> _reformiCandidatesList = new List<string>();
        private List<string> _ekreList = new List<string>();
        private List<string> _ekreCandidatesList = new List<string>();
        private List<string> _tulevikuList = new List<string>();
        private List<string> _tulevikuCandidatesList = new List<string>();
        private List<string> _unknownPartyList = new List<string>();
        private List<string> _unknownCandidatesList = new List<string>();
        private List<string> _partyNamesInFile2TotalList = new List<string>();
        public List<string> _candidatesTotalList = new List<string>();
        private List<string> _isamaaLasnaList = new List<string>();
        private List<string> _isamaaLasnaCandidatesList = new List<string>();
        private List<string> _rohelisedLasnaList = new List<string>();
        private List<string> _rohelisedLasnaCandidatesList = new List<string>();
        private List<string> _vabaEestiLasnaList = new List<string>();
        private List<string> _vabaEestiLasnaCandidatesList = new List<string>();
        private List<string> _sotsidLasnaList = new List<string>();
        private List<string> _sotsidLasnaCandidatesList = new List<string>();
        private List<string> _kesikudLasnaList = new List<string>();
        private List<string> _kesikudLasnaCandidatesList = new List<string>();
        private List<string> _eesti200LasnaList = new List<string>();
        private List<string> _eesti200LasnaCandidatesList = new List<string>();
        private List<string> _narodnyiLasnaList = new List<string>();
        private List<string> _narodnyiLasnaCandidatesList = new List<string>();
        private List<string> _reformiLasnaList = new List<string>();
        private List<string> _reformiLasnaCandidatesList = new List<string>();
        private List<string> _ekreLasnaList = new List<string>();
        private List<string> _ekreLasnaCandidatesList = new List<string>();
        private List<string> _tulevikuLasnaList = new List<string>();
        private List<string> _tulevikuLasnaCandidatesList = new List<string>();
        private List<string> _soloLasnaPartyList = new List<string>();
        private List<string> _soloLasnaCandidatesList = new List<string>();
        private List<string> _lasnaCandidatesTotalList = new List<string>();
        private List<string> _partyNamesInFile3TotalList = new List<string>();
        private List<int> _totalVotersListAsInt = new List<int>();
        private List<int> _paperVotersListAsInt = new List<int>();
        private List<int> _eVotersListAsInt = new List<int>();
        private List<int> _possibleVotersListAsInt = new List<int>();
        private List<int> _totalPopulationListAsInt = new List<int>();
        private List<int> _forecastedResultsListAsInt = new List<int>();
        private List<int> _actualResultsListAsInt = new List<int>();
        private List<int> _isamaaEVotesListAsInt = new List<int>();
        private List<int> _isamaaPaperVotesListAsInt = new List<int>();
        private List<int> _rohelisedEVotesListAsInt = new List<int>();
        private List<int> _rohelisedPaperVotesListAsInt = new List<int>();
        private List<int> _vabaEestiEVotesListAsInt = new List<int>();
        private List<int> _vabaEestiPaperVotesListAsInt = new List<int>();
        private List<int> _sotsidEVotesListAsInt = new List<int>();
        private List<int> _sotsidPaperVotesListAsInt = new List<int>();
        private List<int> _kesikudEVotesListAsInt = new List<int>();
        private List<int> _kesikudPaperVotesListAsInt = new List<int>();
        private List<int> _eesti200EVotesListAsInt = new List<int>();
        private List<int> _eesti200PaperVotesListAsInt = new List<int>();
        private List<int> _narodnyiEVotesListAsInt = new List<int>();
        private List<int> _narodnyiPaperVotesListAsInt = new List<int>();
        private List<int> _reformiEVotesListAsInt = new List<int>();
        private List<int> _reformiPaperVotesListAsInt = new List<int>();
        private List<int> _ekreEVotesListAsInt = new List<int>();
        private List<int> _ekrePaperVotesListAsInt = new List<int>();
        private List<int> _tulevikuEVotesListAsInt = new List<int>();
        private List<int> _tulevikuPaperVotesListAsInt = new List<int>();
        private List<int> _unknownEVotesListAsInt = new List<int>();
        private List<int> _unknownPaperVotesListAsInt = new List<int>();
        private List<int> _eVotesInFile2TotalListAsInt = new List<int>();
        private List<int> _paperVotesInFile2TotalListAsInt = new List<int>();
        private List<int> _totalVotesForCandidatesListAsInt = new List<int>();
        private List<int> _isamaaLasnaEVotesListAsInt = new List<int>();
        private List<int> _isamaaLasnaPaperVotesListAsInt = new List<int>();
        private List<int> _rohelisedLasnaEVotesListAsInt = new List<int>();
        private List<int> _rohelisedLasnaPaperVotesListAsInt = new List<int>();
        private List<int> _vabaEestiLasnaEVotesListAsInt = new List<int>();
        private List<int> _vabaEestiLasnaPaperVotesListAsInt = new List<int>();
        private List<int> _sotsidLasnaEVotesListAsInt = new List<int>();
        private List<int> _sotsidLasnaPaperVotesListAsInt = new List<int>();
        private List<int> _kesikudLasnaEVotesListAsInt = new List<int>();
        private List<int> _kesikudLasnaPaperVotesListAsInt = new List<int>();
        private List<int> _eesti200LasnaEVotesListAsInt = new List<int>();
        private List<int> _eesti200LasnaPaperVotesListAsInt = new List<int>();
        private List<int> _narodnyiLasnaEVotesListAsInt = new List<int>();
        private List<int> _narodnyiLasnaPaperVotesListAsInt = new List<int>();
        private List<int> _reformiLasnaEVotesListAsInt = new List<int>();
        private List<int> _reformiLasnaPaperVotesListAsInt = new List<int>();
        private List<int> _ekreLasnaEVotesListAsInt = new List<int>();
        private List<int> _ekreLasnaPaperVotesListAsInt = new List<int>();
        private List<int> _tulevikuLasnaEVotesListAsInt = new List<int>();
        private List<int> _tulevikuLasnaPaperVotesListAsInt = new List<int>();
        private List<int> _soloLasnaEVotesListAsInt = new List<int>();
        private List<int> _soloLasnaPaperVotesListAsInt = new List<int>();
        private List<int> _eVotesInFile3TotalListAsInt = new List<int>();
        private List<int> _paperVotesInFile3TotalListAsInt = new List<int>();
        private List<int> _totalLasnaVotesForCandidatesListAsInt = new List<int>();
        private List<int> _indexListKesklinn = new List<int>();
        private List<int> _indexListLasna = new List<int>();
        int[] _electionYearsArray = new[] { 1921, 1924, 1927, 1930, 1934, 1939, 1993, 1996, 1999, 2002, 2005, 2009,
                2013, 2017, 2021, 2025, 2029, 2033, 2037, 2041, 2045, 2049, 2053, 2057, 2061, 2065, 2069, 2073, 2077 };
        private string _minRegion;
        private string _maxRegion;
        private string _minMember;
        private string _maxMember;
        private int _index;

        public ElectionResultAnalyzer()
        {
            ReadValuesFromFile1();
            ReadValuesFromFile2();
            ReadValuesFromFile3();
            ReadValuesFromFile4();
            ReadValuesFromFile5();
            ReadValuesFromFile6();
            ConvertListsToInt1();
            ConvertListsToInt2();
        }

        private void ReadValuesFromFile1()
        {
            if (File.Exists(_generalDataFileName))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(_generalDataFileName))
                    {
                        int i = 0;
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] splitline = line.Split(",");
                            if (splitline.Length == 5)
                            {
                                if (i > 0)
                                {
                                    _regionNamesList.Add(splitline[0]);
                                    _paperVotersList.Add(splitline[1]);
                                    _eVotersList.Add(splitline[2]);
                                    _possibleVotersList.Add(splitline[3]);
                                    _totalPopulationList.Add(splitline[4]);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Invalid line in file: {line}");
                            }
                            i++;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error with reading data from file. " +
                    "Please check whether data is entered correctly.");
                }
            }
            else
            {
                Console.WriteLine("File for data about voting regions is not found.");
            }
        }

        private void ReadValuesFromFile2()
        {
            if (File.Exists(_statisticsFileName))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(_statisticsFileName))
                    {
                        int i = 0;
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] splitline = line.Split(";");
                            if (splitline.Length == 3)
                            {
                                if (i > 0)
                                {
                                    _partyNamesList.Add(splitline[0]);
                                    _forecastedResultsList.Add(splitline[1]);
                                    _actualResultsList.Add(splitline[2]);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Invalid line in file: {line}");
                            }
                            i++;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error with reading data from file. " +
                    "Please check whether data is entered correctly.");
                }
            }
            else
            {
                Console.WriteLine("File for data about voting regions is not found.");
            }
        }

        private void ReadValuesFromFile3()
        {

            if (File.Exists(_tallinnKesklinnFileName))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(_tallinnKesklinnFileName))
                    {
                        int i = 0;
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] splitline = line.Split(",");
                            if (splitline.Length == 4)
                            {
                                if (i > 0)
                                {
                                    if (splitline[0].Contains("Isamaa"))
                                    {
                                        _isamaaList.Add(splitline[0]);
                                        _isamaaCandidatesList.Add(splitline[1]);
                                        _isamaaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _isamaaPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Rohelised"))
                                    {
                                        _rohelisedList.Add(splitline[0]);
                                        _rohelisedCandidatesList.Add(splitline[1]);
                                        _rohelisedEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _rohelisedPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Vaba"))
                                    {
                                        _vabaEestiList.Add(splitline[0]);
                                        _vabaEestiCandidatesList.Add(splitline[1]);
                                        _vabaEestiEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _vabaEestiPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Sotsiaal"))
                                    {
                                        _sotsidList.Add(splitline[0]);
                                        _sotsidCandidatesList.Add(splitline[1]);
                                        _sotsidEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _sotsidPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("kesk"))
                                    {
                                        _kesikudList.Add(splitline[0]);
                                        _kesikudCandidatesList.Add(splitline[1]);
                                        _kesikudEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _kesikudPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("200"))
                                    {
                                        _eesti200List.Add(splitline[0]);
                                        _eesti200CandidatesList.Add(splitline[1]);
                                        _eesti200EVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _eesti200PaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Narodnyi"))
                                    {
                                        _narodnyiList.Add(splitline[0]);
                                        _narodnyiCandidatesList.Add(splitline[1]);
                                        _narodnyiEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _narodnyiPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("reform"))
                                    {
                                        _reformiList.Add(splitline[0]);
                                        _reformiCandidatesList.Add(splitline[1]);
                                        _reformiEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _reformiPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Konserv"))
                                    {
                                        _ekreList.Add(splitline[0]);
                                        _ekreCandidatesList.Add(splitline[1]);
                                        _ekreEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _ekrePaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Tulevik"))
                                    {
                                        _tulevikuList.Add(splitline[0]);
                                        _tulevikuCandidatesList.Add(splitline[1]);
                                        _tulevikuEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _tulevikuPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else
                                    {
                                        _unknownPartyList.Add(splitline[0]);
                                        _unknownCandidatesList.Add(splitline[1]);
                                        _unknownEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _unknownPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Invalid line in file: {line}");
                            }
                            i++;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error with reading data from file. " +
                    "Please check whether data is entered correctly.");
                }
            }
            else
            {
                Console.WriteLine("File for data about voting regions is not found.");
            }
        }

        private void ReadValuesFromFile4()
        {
            if (File.Exists(_tallinnKesklinnFileName))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(_tallinnKesklinnFileName))
                    {
                        int i = 0;
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] splitline = line.Split(",");
                            if (splitline.Length == 4)
                            {
                                if (i > 0)
                                {
                                    _partyNamesInFile2TotalList.Add(splitline[0]);
                                    _candidatesTotalList.Add(splitline[1]);
                                    _paperVotesInFile2TotalListAsInt.Add(int.Parse(splitline[2]));
                                    _eVotesInFile2TotalListAsInt.Add(int.Parse(splitline[3]));
                                    _totalVotesForCandidatesListAsInt.Add(int.Parse(splitline[2])
                                        + int.Parse(splitline[3]));
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Invalid line in file: {line}");
                            }
                            i++;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error with reading data from file. " +
                    "Please check whether data is entered correctly.");
                }
            }
            else
            {
                Console.WriteLine("File for data about voting regions is not found.");
            }
        }

        private void ReadValuesFromFile5()
        {

            if (File.Exists(_tallinnLasnamäeFileName))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(_tallinnLasnamäeFileName))
                    {
                        int i = 0;
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] splitline = line.Split(";");
                            if (splitline.Length == 4)
                            {
                                if (i > 0)
                                {
                                    if (splitline[0].Contains("Isamaa"))
                                    {
                                        _isamaaLasnaList.Add(splitline[0]);
                                        _isamaaLasnaCandidatesList.Add(splitline[1]);
                                        _isamaaLasnaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _isamaaLasnaPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Rohelised"))
                                    {
                                        _rohelisedLasnaList.Add(splitline[0]);
                                        _rohelisedLasnaCandidatesList.Add(splitline[1]);
                                        _rohelisedLasnaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _rohelisedPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Vaba"))
                                    {
                                        _vabaEestiLasnaList.Add(splitline[0]);
                                        _vabaEestiLasnaCandidatesList.Add(splitline[1]);
                                        _vabaEestiLasnaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _vabaEestiLasnaPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Sotsiaal"))
                                    {
                                        _sotsidLasnaList.Add(splitline[0]);
                                        _sotsidLasnaCandidatesList.Add(splitline[1]);
                                        _sotsidLasnaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _sotsidLasnaPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("kesk"))
                                    {
                                        _kesikudLasnaList.Add(splitline[0]);
                                        _kesikudLasnaCandidatesList.Add(splitline[1]);
                                        _kesikudLasnaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _kesikudLasnaPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("200"))
                                    {
                                        _eesti200LasnaList.Add(splitline[0]);
                                        _eesti200LasnaCandidatesList.Add(splitline[1]);
                                        _eesti200LasnaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _eesti200LasnaPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Narodnyi"))
                                    {
                                        _narodnyiLasnaList.Add(splitline[0]);
                                        _narodnyiLasnaCandidatesList.Add(splitline[1]);
                                        _narodnyiLasnaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _narodnyiLasnaPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("reform"))
                                    {
                                        _reformiLasnaList.Add(splitline[0]);
                                        _reformiLasnaCandidatesList.Add(splitline[1]);
                                        _reformiLasnaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _reformiLasnaPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Konserv"))
                                    {
                                        _ekreLasnaList.Add(splitline[0]);
                                        _ekreLasnaCandidatesList.Add(splitline[1]);
                                        _ekreLasnaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _ekreLasnaPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Tulevik"))
                                    {
                                        _tulevikuLasnaList.Add(splitline[0]);
                                        _tulevikuLasnaCandidatesList.Add(splitline[1]);
                                        _tulevikuLasnaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _tulevikuLasnaPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                    else if (splitline[0].Contains("Üksik"))
                                    {
                                        _soloLasnaPartyList.Add(splitline[0]);
                                        _soloLasnaCandidatesList.Add(splitline[1]);
                                        _soloLasnaEVotesListAsInt.Add(int.Parse(splitline[2]));
                                        _soloLasnaPaperVotesListAsInt.Add(int.Parse(splitline[3]));
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Invalid line in file: {line}");
                            }
                            i++;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error with reading data from file. " +
                    "Please check whether data is entered correctly.");
                }
            }
            else
            {
                Console.WriteLine("File for data about voting regions is not found.");
            }
        }

        private void ReadValuesFromFile6()
        {
            if (File.Exists(_tallinnLasnamäeFileName))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(_tallinnLasnamäeFileName))
                    {
                        int i = 0;
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] splitline = line.Split(";");
                            if (splitline.Length == 4)
                            {
                                if (i > 0)
                                {
                                    _partyNamesInFile3TotalList.Add(splitline[0]);
                                    _lasnaCandidatesTotalList.Add(splitline[1]);
                                    _eVotesInFile3TotalListAsInt.Add(int.Parse(splitline[2]));
                                    _paperVotesInFile3TotalListAsInt.Add(int.Parse(splitline[3]));
                                    _totalLasnaVotesForCandidatesListAsInt.Add(int.Parse(splitline[2])
                                        + int.Parse(splitline[3]));
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Invalid line in file: {line}");
                            }
                            i++;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error with reading data from file. " +
                    "Please check whether data is entered correctly.");
                }
            }
            else
            {
                Console.WriteLine("File for data about voting regions is not found.");
            }
        }

        public void ConvertListsToInt1()
        {
            try
            {
                for (int i = 0; i < _paperVotersList.Count; i++)
                {
                    _paperVotersListAsInt.Add(int.Parse(_paperVotersList[i]));
                    _eVotersListAsInt.Add(int.Parse(_eVotersList[i]));
                    _possibleVotersListAsInt.Add(int.Parse(_possibleVotersList[i]));
                    _totalPopulationListAsInt.Add(int.Parse(_totalPopulationList[i]));
                }
                for (int i = 0; i < _paperVotersListAsInt.Count; i++)
                {
                    _totalVotersListAsInt.Add(_paperVotersListAsInt[i] + _eVotersListAsInt[i]);
                }
            }
            catch
            {
                Console.WriteLine("Lines in file not in correct format. All lines in" +
                    " e-Votes and paper votes columns must be numbers.");
            }
        }

        public void ConvertListsToInt2()
        {
            try
            {
                for (int i = 0; i < _forecastedResultsList.Count; i++)
                {
                    _forecastedResultsListAsInt.Add(int.Parse(_forecastedResultsList[i]));
                    _actualResultsListAsInt.Add(int.Parse(_actualResultsList[i]));
                }
            }
            catch
            {
                Console.WriteLine("Lines in file not in correct format. All lines in" +
                    " e-Votes and paper votes columns must be numbers.");
            }
        }

        public int FindMinCouncilMembersNeeded(int population)
        {
            int _minCouncilMembersCount = 0;

            if (population <= 2000 && population >= 0)
            {
                _minCouncilMembersCount = 7;
            }
            else if (population > 2000 && population <= 3500)
            {
                _minCouncilMembersCount = 13;
            }
            else if (population > 3500 && population <= 5000)
            {
                _minCouncilMembersCount = 15;
            }
            else if (population > 5000 && population <= 7500)
            {
                _minCouncilMembersCount = 17;
            }
            else if (population > 7500 && population <= 10000)
            {
                _minCouncilMembersCount = 19;
            }
            else if (population > 10000 && population <= 30000)
            {
                _minCouncilMembersCount = 21;
            }
            else if (population > 30000 && population <= 50000)
            {
                _minCouncilMembersCount = 25;
            }
            else if (population > 50000 && population <= 300000)
            {
                _minCouncilMembersCount = 31;
            }
            else if (population > 300000)
            {
                _minCouncilMembersCount = 79;
            }
            else
            {
                Console.WriteLine("Value can only be a positive number.");
            }
            return _minCouncilMembersCount;
        }

        public void PrintMinCouncilMembers()
        {
            Console.WriteLine("Minimum number of council members needed: \n");
            for (int i = 0; i < _totalPopulationList.Count; i++)
            {
                int population = Convert.ToInt32(_totalPopulationList[i]);
                int _minCouncilMembersCount = FindMinCouncilMembersNeeded(population);
                Console.WriteLine($"{_regionNamesList[i]}: at least {_minCouncilMembersCount} members");
            }
        }

        public double[] FindMinAndMaxRates(List<int> intListOne,
            List<int> intListTwo, List <string> stringListOne, List<string> stringListTwo)
        {
            List<double> votingTurnoutPercentageList = new List<double>();
            for (int i = 0; i < intListOne.Count; i++)
            {
                double votingTurnoutPercentage = Math.Round(Convert.ToDouble(intListOne[i]) /
                    Convert.ToDouble(intListTwo[i]) * 100, 1);
                votingTurnoutPercentageList.Add(votingTurnoutPercentage);
            }

            double minValue = votingTurnoutPercentageList.Min();
            double maxValue = votingTurnoutPercentageList.Max();
            int indexMinValue = votingTurnoutPercentageList.IndexOf(minValue);
            int indexMaxValue = votingTurnoutPercentageList.IndexOf(maxValue);
            _minRegion = stringListOne[indexMinValue];
            _maxRegion = stringListTwo[indexMaxValue];

            double[] minMaxEVotingTurnoutArray = { minValue, maxValue };

            return minMaxEVotingTurnoutArray;
        }

        public void PrintMinAndMaxEVoterTurnoutRates()
        {
            double[] x = FindMinAndMaxRates(_eVotersListAsInt,
                _totalVotersListAsInt, _regionNamesList, _regionNamesList);
            double minValue = x[0];
            double maxValue = x[1];
            Console.WriteLine($"The lowest e-voting turnout rate was at {_minRegion}" +
                $" with {minValue}% \n" +
                $"The highest e-voting turnout rate was at {_maxRegion} with {maxValue}%");
        }

        public void PrintMinAndMaxPaperVoterTurnoutRates()
        {
            double[] x = FindMinAndMaxRates(_paperVotersListAsInt,
                _totalVotersListAsInt, _regionNamesList, _regionNamesList);
            double minValue = x[0];
            double maxValue = x[1];
            Console.WriteLine($"The lowest paper voting turnout rate was at {_minRegion}" +
                $" with {minValue}% \n" +
                $"The highest paper voting turnout rate was at {_maxRegion} with {maxValue}%");
        }

        public void PrintMinAndMaxTotalVoterTurnoutRates()
        {
            double[] x = FindMinAndMaxRates(_totalVotersListAsInt,
                _possibleVotersListAsInt, _regionNamesList, _regionNamesList);
            double minValue = x[0];
            double maxValue = x[1];
            Console.WriteLine($"The lowest voter turnout rate was at {_minRegion}" +
                $" with {minValue}% \n" +
                $"The highest voter turnout rate was at {_maxRegion} with {maxValue}%");
        }

        public void PrintMinAndMaxEligibleVotersPercentages()
        {
            double[] x = FindMinAndMaxRates(_possibleVotersListAsInt,
                _totalPopulationListAsInt, _regionNamesList, _regionNamesList);
            double minValue = x[0];
            double maxValue = x[1];
            Console.WriteLine($"The region with the lowest percentage of " +
                $"eligible voters is {_minRegion} with {minValue}% \n" +
                $"The region with the highest percentage of eligible voters" +
                $" is {_maxRegion} with {maxValue}%");
        }

        public void InfoForASpecificRegion(string input)
        {
            string regionName = ValidateInputToCorrectFormat(input);
            try
            {
                for (int i = 0; i < _regionNamesList.Count; i++)
                {
                    if (_regionNamesList[i].Contains(regionName))
                    {
                        string regionNameInList = _regionNamesList[i];
                        double totalVotingTurnoutPercentage = Math.Round(Convert.ToDouble(_totalVotersListAsInt[i]) /
                        Convert.ToDouble(_possibleVotersListAsInt[i]) * 100, 1);
                        double eVotingTurnoutPercentage = Math.Round(Convert.ToDouble(_eVotersListAsInt[i]) /
                        Convert.ToDouble(_totalVotersListAsInt[i]) * 100, 1);
                        double paperVotingTurnoutPercentage = Math.Round(Convert.ToDouble(_paperVotersListAsInt[i]) /
                        Convert.ToDouble(_totalVotersListAsInt[i]) * 100, 1);
                        Console.WriteLine($"{regionNameInList}:\n\n" +
                            $"Total voter turnout: {totalVotingTurnoutPercentage}%\n" +
                            $"E-voting turnout: {eVotingTurnoutPercentage}%\n" +
                            $"Paper voting turnout: {paperVotingTurnoutPercentage}%\n");
                    }
                }
            }
            catch
            {
                Console.WriteLine($"Entered region name either doesn't exist in" +
                    " the file or you made a typo. Please check input and spelling.\n");
            }
        }

        public string ValidateInputToCorrectFormat(string name)
        {
            List<char> nameAsCharsList = new List<char>();
            if (name.Length > 1)
            {
                nameAsCharsList.Add(char.ToUpper(name[0]));
                for (int i = 1; i < name.Length; i++)
                {
                    nameAsCharsList.Add(char.ToLower(name[i]));
                }
                if (nameAsCharsList.Contains('-'))//Lääne-Viru and Ida-Viru counties
                {
                    int index = nameAsCharsList.FindIndex(x => x.Equals('-'));
                    if (index != -1) //found a match
                    {
                        nameAsCharsList[index + 1] = 'V';
                    }
                }
                name = string.Join("", nameAsCharsList); //join list for string
            }
            else
            {
                Console.WriteLine($"Region name must be longer than one character.");
            }
            return name;
        }

        public double CalculateTotalVoterTurnout()
        {
            double totalVoterTurnoutRate = Math.Round(Convert.ToDouble(_totalVotersListAsInt.Sum()) /
                    Convert.ToDouble(_possibleVotersListAsInt.Sum()) * 100, 1);
            return totalVoterTurnoutRate;
        }

        public int CalculateTotalVoters()
        {
            int totalVoters = _totalVotersListAsInt.Sum();
            return totalVoters;
        }

        public void SortRegionsByVoterTurnout()
        {
            Console.WriteLine("Voter turnout across counties:\n");
            double[] votingTurnoutPercentageArray = new double[_regionNamesList.Count];
            string[] regionNamesArray = new string[_regionNamesList.Count];
            for (int i = 0; i < _regionNamesList.Count; i++)
            {
                votingTurnoutPercentageArray[i] = Math.Round(Convert.ToDouble(_totalVotersListAsInt[i]) /
                    Convert.ToDouble(_possibleVotersListAsInt[i]) * 100, 1);
                regionNamesArray[i] = _regionNamesList[i];
            }
            Array.Sort(votingTurnoutPercentageArray, regionNamesArray);
            for (int i = 0; i < votingTurnoutPercentageArray.Length; i++)
            {
                Console.WriteLine($"{regionNamesArray[i]}: {votingTurnoutPercentageArray[i]}%");
            }
        }

        public void PrintSummaryInfo()
        {
            double totalVoterTurnout = CalculateTotalVoterTurnout();
            int totalVoters = CalculateTotalVoters();
            Console.WriteLine($"Total voting activity across the country was {totalVoterTurnout}%, " +
                $"the total number of voters being {totalVoters} people.\n");
            SortRegionsByVoterTurnout();
        }

        public int[] FindLowerAndHigherYear(int year)
        {
            int lowerYear = 0;
            int higherYear = 0;

            _index = Array.BinarySearch(_electionYearsArray, year);
            if (_index >= 0) //match found
            {
                if (_index > 0)
                    lowerYear = _electionYearsArray[_index - 1];
                if (_index < _electionYearsArray.Length - 1)
                    higherYear = _electionYearsArray[_index + 1];
            }
            else //match not found
            {
                _index = ~_index; //inverse, because BinarySearch returned a negative number
                if (_index < _electionYearsArray.Length)
                    higherYear = _electionYearsArray[_index];
                if (_index > 0)
                    lowerYear = _electionYearsArray[_index - 1];
            }
            int[] lowYearHighYearArray = { lowerYear, higherYear };

            return lowYearHighYearArray;
        }

        public void PrintWhenElectionsAreHeld(int year)
        {
            int[] x = FindLowerAndHigherYear(year);
            int lowerYear = x[0];
            int higherYear = x[1];
            int currentYear = int.Parse(DateTime.Now.Year.ToString());

            if (year < 0)
            {
                Console.WriteLine("Year cannot be a negative number.");
            }
            else if (year >= 0 && year < 1921 || year > 2077)
            {
                Console.WriteLine("No info about those years. Choose a year between 1921 and 2077.");
            }
            else
            {
                if (year == currentYear)
                {
                    if (_electionYearsArray.Contains(year))
                    {
                        Console.WriteLine($"Elections are held this year.");
                    }
                    else
                    {
                        Console.WriteLine($"Elections won't be held this year, but elections were" +
                            $" held in {lowerYear} and will be held next in {higherYear}.");
                    }
                }
                else if (year > currentYear)
                {
                    if (_electionYearsArray.Contains(year))
                    {
                        Console.WriteLine($"Elections will be held in {year}.");
                    }
                    else
                    {
                        Console.WriteLine($"Elections won't be held in {year}, but elections will" +
                            $" be held in {lowerYear} and {higherYear}.");
                    }
                }
                else if (year < currentYear)
                {
                    if (_electionYearsArray.Contains(year))
                    {
                        Console.WriteLine($"Elections were held in {year}.");
                    }
                    else
                    {
                        Console.WriteLine($"Elections weren't held in {year}, but elections were" +
                            $" held in {lowerYear} and {higherYear}.");
                    }
                }
            }
        }

        public string FindBirthday(string idCode)
        {
            string birthdayAsString = "";
            string firstNumberOfIdCode = idCode.Substring(0, 1);
            string yearNumbersOfIdCode = idCode.Substring(1, 2);
            string monthNumbersOfIdCode = idCode.Substring(3, 2);
            string dayNumbersOfIdCode = idCode.Substring(5, 2);

            if (firstNumberOfIdCode == "1" ||
                firstNumberOfIdCode == "2")
            {
                birthdayAsString = $"18{yearNumbersOfIdCode}-" +
                    $"{monthNumbersOfIdCode}-{dayNumbersOfIdCode}";
            }
            else if (firstNumberOfIdCode == "3" ||
                firstNumberOfIdCode == "4")
            {
                birthdayAsString = $"19{yearNumbersOfIdCode}-" +
                    $"{monthNumbersOfIdCode}-{dayNumbersOfIdCode}";
            }
            else if (firstNumberOfIdCode == "5" ||
                     firstNumberOfIdCode == "6")
            {
                birthdayAsString = $"20{yearNumbersOfIdCode}-" +
                    $"{monthNumbersOfIdCode}-{dayNumbersOfIdCode}";
            }
            else if (firstNumberOfIdCode == "7" ||
                     firstNumberOfIdCode == "8")
            {
                birthdayAsString = $"21{yearNumbersOfIdCode}-" +
                    $"{monthNumbersOfIdCode}-{dayNumbersOfIdCode}";
            }
            return birthdayAsString;
        }

        public bool[] FindVotingAndCandidateEligibility(string idCode)
        {
            bool canVote = false;
            bool canBecomeACandidate = false;
            string birthdayAsString = FindBirthday(idCode);
            DateTime birthday = DateTime.Parse(birthdayAsString.ToString());
            DateTime eligibleToVote = new DateTime(2005, 08, 07);
            DateTime eligibleToBecomeACandidate = new DateTime(2003, 09, 12);
            int compareVote = DateTime.Compare(birthday, eligibleToVote);
            int compareCandidate = DateTime.Compare(birthday, eligibleToBecomeACandidate);

            if (compareVote <= 0)
            {
                canVote = true;
            }
            if (compareCandidate <= 0)
            {
                canBecomeACandidate = true;
            }

            bool[] eligibilityArray = { canVote, canBecomeACandidate };
            return eligibilityArray;
        }

        public void EligibilityCheckFor2021Elections(string idCode)
        {
            bool[] x = FindVotingAndCandidateEligibility(idCode);
            bool canVote = x[0];
            bool canBecomeACandidate = x[1];

            if (!canVote && !canBecomeACandidate)
            {
                Console.WriteLine("Can't vote, can't become a candidate.");
            }
            else if (canVote && !canBecomeACandidate)
            {
                Console.WriteLine("Can vote, can't become a candidate.");
            }
            else if (canVote && canBecomeACandidate)
            {
                Console.WriteLine("Can vote, can become a candidate.");
            }
        }

        public string RemoveSpecialCharsFromName(string name)
        {
            List<char> _charsToRemoveList = new List<char>(){'(',')',':','!','#','$',
            '%','&','\'','*','+','-',',','/','=','?','^','_','`','{','|','}','~','.'};
            List<char> dottedChars = new List<char>() {'š','ž','õ','ä','ö','ü','Š','Ž','Õ','Ä','Ö','Ü'};
            List<char> replacementChars = new List<char>() {'s','z','o','a','o','u','s','z','o','a','o','u'};

            string nameWithoutDots = string.Empty;
            foreach (char c in name)
            {
                if (!_charsToRemoveList.Contains(c))
                {
                    int dottedCharIndex = dottedChars.IndexOf(c);
                    if (dottedCharIndex != -1)
                    {
                        nameWithoutDots += replacementChars[dottedCharIndex];
                    }
                    else
                    {
                        nameWithoutDots += c;
                    }
                }
            }
            return nameWithoutDots;
        }

        public string CreateUsername(string name)
        {
            string username = "";
            string forenames = "";
            string lastname = "";
            string forenamesForUsername = "";
            string nameWithoutDots = RemoveSpecialCharsFromName(name);

            if (name.Contains(' ')) //entered name has at least one space
            {
                int index = nameWithoutDots.LastIndexOf(' ');
                forenames = nameWithoutDots.Substring(0, index);
                lastname = nameWithoutDots.Substring(index + 1, nameWithoutDots.Length - index - 1);
                if (forenames.Contains(' '))
                {
                    string[] forenameParts = forenames.Split(' ');
                    for (int i = 0; i < forenameParts.Length; i++)
                    {
                        if (forenameParts[i].Length > 3)
                        {
                            forenamesForUsername += forenameParts[i].Substring(0, 3);
                            //get first 3 letters of each forename
                        }
                        else
                        {
                            forenamesForUsername += forenameParts[i];
                        }
                    }
                }
                else
                {
                    forenamesForUsername = forenames;
                }
                forenamesForUsername = forenamesForUsername.Replace(" ", string.Empty); //remove whitespaces
                if (forenamesForUsername.Length > 6)
                {
                    forenamesForUsername = forenamesForUsername.Substring(0, 6); //max 6 chars
                }
                if (lastname.Length > 6)
                {
                    lastname = lastname.Substring(0, 6); //max 6 chars
                }
                username = $"{forenamesForUsername}.{lastname}";
            }
            else
            {
                username = nameWithoutDots;
                if (username.Length > 6)
                {
                    username = username.Substring(0, 6);
                }
            }

            username = username.ToLower();
            username = username.Trim();
            SaveUsernamesToFile(username);
            return username;
        }

        public void SaveUsernamesToFile(string username)
        {
            _usernamesList.Add(username);
            using (StreamWriter writer = new StreamWriter("usernames.txt"))
            {
                for (int i = 0; i < _usernamesList.Count; i++)
                {
                    writer.WriteLine(_usernamesList[i]);
                }
            }
        }

        public void PrintUsername(string name)
        {
            string username = CreateUsername(name);
            Console.WriteLine($"{username}");
        }

        public void PrintBiggestWinnersAndLosers()
        {
            double[] x = FindMinAndMaxRates(_forecastedResultsListAsInt,
                _actualResultsListAsInt, _partyNamesList, _partyNamesList);
            double minValue = x[0];
            double maxValue = x[1];
            Console.WriteLine($"The biggest winners were {_maxRegion} as" +
                $" they got {maxValue}% of expected results.\n" +
                $"The biggest losers were {_minRegion} as" +
                $" they got {minValue}% of expected results.");
        }

        public int FindTotalVoters(string partyName)
        {
            int totalVoters = 0;
            try
            {
                if (partyName == "erakond" || partyName == "Erakond" ||
                partyName == "Eesti" || partyName == "eesti")
                {
                    Console.WriteLine("Please be more specific.");
                }
                else
                {
                    if (_isamaaList[0].Contains(partyName))
                    {
                        totalVoters = _isamaaEVotesListAsInt.Sum() + _isamaaPaperVotesListAsInt.Sum();
                    }
                    else if (_rohelisedList[0].Contains(partyName))
                    {
                        totalVoters = _rohelisedEVotesListAsInt.Sum() + _rohelisedPaperVotesListAsInt.Sum();
                    }
                    else if (_vabaEestiList[0].Contains(partyName))
                    {
                        totalVoters = _vabaEestiEVotesListAsInt.Sum() + _vabaEestiPaperVotesListAsInt.Sum();
                    }
                    else if (_sotsidList[0].Contains(partyName))
                    {
                        totalVoters = _sotsidEVotesListAsInt.Sum() + _sotsidPaperVotesListAsInt.Sum();
                    }
                    else if (_kesikudList[0].Contains(partyName))
                    {
                        totalVoters = _kesikudEVotesListAsInt.Sum() + _kesikudPaperVotesListAsInt.Sum();
                    }
                    else if (_eesti200List[0].Contains(partyName))
                    {
                        totalVoters = _eesti200EVotesListAsInt.Sum() + _eesti200PaperVotesListAsInt.Sum();
                    }
                    else if (_narodnyiList[0].Contains(partyName))
                    {
                        totalVoters = _narodnyiEVotesListAsInt.Sum() + _narodnyiPaperVotesListAsInt.Sum();
                    }
                    else if (_reformiList[0].Contains(partyName))
                    {
                        totalVoters = _reformiEVotesListAsInt.Sum() + _reformiPaperVotesListAsInt.Sum();
                    }
                    else if (_ekreList[0].Contains(partyName))
                    {
                        totalVoters = _ekreEVotesListAsInt.Sum() + _ekrePaperVotesListAsInt.Sum();
                    }
                    else if (_tulevikuList[0].Contains(partyName))
                    {
                        totalVoters = _tulevikuEVotesListAsInt.Sum() + _tulevikuPaperVotesListAsInt.Sum();
                    }
                    else if (_unknownPartyList[0].Contains(partyName))
                    {
                        totalVoters = _unknownEVotesListAsInt.Sum() + _unknownPaperVotesListAsInt.Sum();
                    }
                }
            }
            catch
            {
                Console.WriteLine($"Entered party name either doesn't exist in" +
                    " the file or you made a typo. Please check input and spelling.\n");
            }
            return totalVoters;
        }

        public int FindTotalVotersForLasnamäe(string partyName)
        {
            int totalVoters = 0;
            try
            {
                if (partyName == "erakond" || partyName == "Erakond" ||
                partyName == "Eesti" || partyName == "eesti")
                {
                    Console.WriteLine("Please be more specific.");
                }
                else
                {
                    if (_isamaaLasnaList[0].Contains(partyName))
                    {
                        totalVoters = _isamaaLasnaEVotesListAsInt.Sum() + _isamaaLasnaPaperVotesListAsInt.Sum();
                    }
                    else if (_rohelisedLasnaList[0].Contains(partyName))
                    {
                        totalVoters = _rohelisedLasnaEVotesListAsInt.Sum() + _rohelisedLasnaPaperVotesListAsInt.Sum();
                    }
                    else if (_vabaEestiLasnaList[0].Contains(partyName))
                    {
                        totalVoters = _vabaEestiLasnaEVotesListAsInt.Sum() + _vabaEestiLasnaPaperVotesListAsInt.Sum();
                    }
                    else if (_sotsidLasnaList[0].Contains(partyName))
                    {
                        totalVoters = _sotsidLasnaEVotesListAsInt.Sum() + _sotsidLasnaPaperVotesListAsInt.Sum();
                    }
                    else if (_kesikudLasnaList[0].Contains(partyName))
                    {
                        totalVoters = _kesikudEVotesListAsInt.Sum() + _kesikudPaperVotesListAsInt.Sum();
                    }
                    else if (_eesti200LasnaList[0].Contains(partyName))
                    {
                        totalVoters = _eesti200LasnaEVotesListAsInt.Sum() + _eesti200LasnaPaperVotesListAsInt.Sum();
                    }
                    else if (_narodnyiLasnaList[0].Contains(partyName))
                    {
                        totalVoters = _narodnyiLasnaEVotesListAsInt.Sum() + _narodnyiLasnaPaperVotesListAsInt.Sum();
                    }
                    else if (_reformiLasnaList[0].Contains(partyName))
                    {
                        totalVoters = _reformiLasnaEVotesListAsInt.Sum() + _reformiLasnaPaperVotesListAsInt.Sum();
                    }
                    else if (_ekreLasnaList[0].Contains(partyName))
                    {
                        totalVoters = _ekreLasnaEVotesListAsInt.Sum() + _ekreLasnaPaperVotesListAsInt.Sum();
                    }
                    else if (_tulevikuLasnaList[0].Contains(partyName))
                    {
                        totalVoters = _tulevikuLasnaEVotesListAsInt.Sum() + _tulevikuLasnaPaperVotesListAsInt.Sum();
                    }
                    else if (_soloLasnaPartyList[0].Contains(partyName))
                    {
                        totalVoters = _soloLasnaEVotesListAsInt.Sum() + _soloLasnaPaperVotesListAsInt.Sum();
                    }
                }
            }
            catch
            {
                Console.WriteLine($"Entered party name either doesn't exist in" +
                    " the file or you made a typo. Please check input and spelling.\n");
            }
            return totalVoters;
        }

        public void PrintTotalKesklinnVotesForASpecificParty(string partyName)
        {
            int index = _partyNamesInFile2TotalList.FindLastIndex(x => x.Contains(partyName));
            string party = _partyNamesInFile2TotalList[index];
            int totalVoters = FindTotalVoters(partyName);
            Console.WriteLine($"Total number of votes for {party} in Tallinn Kesklinn: {totalVoters}");
        }

        public void PrintTotalLasnamäeVotesForASpecificParty(string partyName)
        {
            int index = _partyNamesInFile3TotalList.FindLastIndex(x => x.Contains(partyName));
            string party = _partyNamesInFile3TotalList[index];
            int totalVoters = FindTotalVotersForLasnamäe(partyName);
            Console.WriteLine($"Total number of votes for {party} in Tallinn Lasnamäe: {totalVoters}");
        }

        public int[] FindBiggestWinnerAndLoserInAPartyInKesklinn(string partyName)
        {
            int totalVotes = 0;
            List<int> votesForCandidatesList = new List<int>();
            List<string> candidatesList = new List<string>();
            try
            {
                if (partyName == "erakond" || partyName == "Erakond" ||
                partyName == "Eesti" || partyName == "eesti")
                {
                    Console.WriteLine("Please be more specific.");
                }
                else
                {
                    if (_isamaaList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _isamaaCandidatesList.Count; i++)
                        {
                            totalVotes = _isamaaEVotesListAsInt[i] + _isamaaPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _isamaaCandidatesList;
                        }
                    }
                    else if (_rohelisedList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _rohelisedCandidatesList.Count; i++)
                        {
                            totalVotes = _rohelisedEVotesListAsInt[i] + _rohelisedPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _rohelisedCandidatesList;
                        }
                    }
                    else if (_vabaEestiList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _vabaEestiCandidatesList.Count; i++)
                        {
                            totalVotes = _vabaEestiEVotesListAsInt[i] + _vabaEestiPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _vabaEestiCandidatesList;
                        }
                    }
                    else if (_sotsidList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _sotsidCandidatesList.Count; i++)
                        {
                            totalVotes = _sotsidEVotesListAsInt[i] + _sotsidPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _sotsidCandidatesList;
                        }
                    }
                    else if (_kesikudList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _kesikudCandidatesList.Count; i++)
                        {
                            totalVotes = _kesikudEVotesListAsInt[i] + _kesikudPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _kesikudCandidatesList;
                        }
                    }
                    else if (_eesti200List[0].Contains(partyName))
                    {
                        for (int i = 0; i < _eesti200CandidatesList.Count; i++)
                        {
                            totalVotes = _eesti200EVotesListAsInt[i] + _eesti200PaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _eesti200CandidatesList;
                        }
                    }
                    else if (_narodnyiList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _narodnyiCandidatesList.Count; i++)
                        {
                            totalVotes = _narodnyiEVotesListAsInt[i] + _narodnyiPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _narodnyiCandidatesList;
                        }
                    }
                    else if (_reformiList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _reformiCandidatesList.Count; i++)
                        {
                            totalVotes = _reformiEVotesListAsInt[i] + _reformiPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _reformiCandidatesList;
                        }
                    }
                    else if (_ekreList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _ekreCandidatesList.Count; i++)
                        {
                            totalVotes = _ekreEVotesListAsInt[i] + _ekrePaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _ekreCandidatesList;
                        }
                    }
                    else if (_tulevikuList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _tulevikuCandidatesList.Count; i++)
                        {
                            totalVotes = _tulevikuEVotesListAsInt[i] + _tulevikuPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _tulevikuCandidatesList;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine($"Entered party name either doesn't exist in" +
                    " the file or you made a typo. Please check input and spelling.\n");
            }

            int minValue = votesForCandidatesList.Min();
            int maxValue = votesForCandidatesList.Max();
            int indexMinValue = votesForCandidatesList.IndexOf(minValue);
            int indexMaxValue = votesForCandidatesList.IndexOf(maxValue);
            _minMember = candidatesList[indexMinValue];
            _maxMember = candidatesList[indexMaxValue];

            int[] minAndMaxVotesArray = { minValue , maxValue };

            return minAndMaxVotesArray;
        }

        public int[] FindBiggestWinnerAndLoserInAPartyInLasnamäe(string partyName)
        {
            int totalVotes = 0;
            List<int> votesForCandidatesList = new List<int>();
            List<string> candidatesList = new List<string>();
            try
            {
                if (partyName == "erakond" || partyName == "Erakond" ||
                partyName == "Eesti" || partyName == "eesti")
                {
                    Console.WriteLine("Please be more specific.");
                }
                else
                {
                    if (_isamaaLasnaList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _isamaaLasnaCandidatesList.Count; i++)
                        {
                            totalVotes = _isamaaLasnaEVotesListAsInt[i] + _isamaaLasnaPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _isamaaLasnaCandidatesList;
                        }
                    }
                    else if (_rohelisedLasnaList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _rohelisedLasnaCandidatesList.Count; i++)
                        {
                            totalVotes = _rohelisedLasnaEVotesListAsInt[i] + _rohelisedLasnaPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _rohelisedLasnaCandidatesList;
                        }
                    }
                    else if (_vabaEestiList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _vabaEestiLasnaCandidatesList.Count; i++)
                        {
                            totalVotes = _vabaEestiLasnaEVotesListAsInt[i] + _vabaEestiLasnaPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _vabaEestiLasnaCandidatesList;
                        }
                    }
                    else if (_sotsidLasnaList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _sotsidLasnaCandidatesList.Count; i++)
                        {
                            totalVotes = _sotsidLasnaEVotesListAsInt[i] + _sotsidLasnaPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _sotsidLasnaCandidatesList;
                        }
                    }
                    else if (_kesikudLasnaList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _kesikudLasnaCandidatesList.Count; i++)
                        {
                            totalVotes = _kesikudLasnaEVotesListAsInt[i] + _kesikudLasnaPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _kesikudLasnaCandidatesList;
                        }
                    }
                    else if (_eesti200LasnaList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _eesti200LasnaCandidatesList.Count; i++)
                        {
                            totalVotes = _eesti200LasnaEVotesListAsInt[i] + _eesti200LasnaPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _eesti200LasnaCandidatesList;
                        }
                    }
                    else if (_narodnyiLasnaList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _narodnyiLasnaCandidatesList.Count; i++)
                        {
                            totalVotes = _narodnyiLasnaEVotesListAsInt[i] + _narodnyiLasnaPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _narodnyiLasnaCandidatesList;
                        }
                    }
                    else if (_reformiList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _reformiLasnaCandidatesList.Count; i++)
                        {
                            totalVotes = _reformiLasnaEVotesListAsInt[i] + _reformiLasnaPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _reformiLasnaCandidatesList;
                        }
                    }
                    else if (_ekreList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _ekreLasnaCandidatesList.Count; i++)
                        {
                            totalVotes = _ekreLasnaEVotesListAsInt[i] + _ekreLasnaPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _ekreLasnaCandidatesList;
                        }
                    }
                    else if (_tulevikuLasnaList[0].Contains(partyName))
                    {
                        for (int i = 0; i < _tulevikuLasnaCandidatesList.Count; i++)
                        {
                            totalVotes = _tulevikuLasnaEVotesListAsInt[i] + _tulevikuLasnaPaperVotesListAsInt[i];
                            votesForCandidatesList.Add(totalVotes);
                            candidatesList = _tulevikuLasnaCandidatesList;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine($"Entered party name either doesn't exist in" +
                    " the file or you made a typo. Please check input and spelling.\n");
            }

            int minValue = votesForCandidatesList.Min();
            int maxValue = votesForCandidatesList.Max();
            int indexMinValue = votesForCandidatesList.IndexOf(minValue);
            int indexMaxValue = votesForCandidatesList.IndexOf(maxValue);
            _minMember = candidatesList[indexMinValue];
            _maxMember = candidatesList[indexMaxValue];

            int[] minAndMaxVotesArray = { minValue, maxValue };

            return minAndMaxVotesArray;
        }

        public void PrintPartysBiggestWinnerAndLoserInKesklinn(string partyName)
        {
            int index = _partyNamesInFile2TotalList.FindLastIndex(x => x.Contains(partyName));
            string party = _partyNamesInFile2TotalList[index];
            int[] x = FindBiggestWinnerAndLoserInAPartyInKesklinn(partyName);
            int minValue = x[0];
            int maxValue = x[1];
            
            Console.WriteLine($"Candidates who got the most and least votes at {party} in Tallinn" +
                $" Kesklinn:\n{_maxMember} ({maxValue})\n{_minMember} ({minValue})");
        }

        public void PrintPartysBiggestWinnerAndLoserInLasnamäe(string partyName)
        {
            int index = _partyNamesInFile2TotalList.FindLastIndex(x => x.Contains(partyName));
            string party = _partyNamesInFile2TotalList[index];
            int[] x = FindBiggestWinnerAndLoserInAPartyInLasnamäe(partyName);
            int minValue = x[0];
            int maxValue = x[1];

            Console.WriteLine($"Candidates who got the most and least votes at {party} in Tallinn" +
                $" Lasnamäe:\n{_maxMember} ({maxValue})\n{_minMember} ({minValue})");
        }

        public List<string> FindCandidatesWhoGot0EOrPaperVotes(List<string> stringListOne,
            List<int> intListOne, List<int> intListTwo, List<string> stringListTwo)
        {
            List<string> candidatesWhoGot0EOrPaperVotesList = new List<string>();
            for (int i = 0; i < stringListOne.Count; i++)
            {
                if (intListOne[i] == 0 ||
                    intListTwo[i] == 0)
                {
                    candidatesWhoGot0EOrPaperVotesList.Add(stringListTwo[i]);
                }
            }
            return candidatesWhoGot0EOrPaperVotesList;
        }

        public void PrintCandidatesWhoGot0EOrPaperVotesInKesklinn()
        {
            Console.WriteLine("Candidates who got 0 e or paper votes in Tallinn Kesklinn:");
            List<string> candidateList = FindCandidatesWhoGot0EOrPaperVotes(_partyNamesInFile2TotalList,
                _eVotesInFile2TotalListAsInt, _paperVotesInFile2TotalListAsInt, _candidatesTotalList);
            foreach (string candidate in candidateList)
            {
                Console.WriteLine(candidate);
            }
        }

        public void PrintCandidatesWhoGot0EOrPaperVotesInLasnamäe()
        {
            Console.WriteLine("Candidates who got 0 e or paper votes in Tallinn Lasnamäe:");
            List<string> candidateList = FindCandidatesWhoGot0EOrPaperVotes(_partyNamesInFile3TotalList,
                _eVotesInFile3TotalListAsInt, _paperVotesInFile3TotalListAsInt, _lasnaCandidatesTotalList);
            foreach (string candidate in candidateList)
            {
                Console.WriteLine(candidate);
            }
        }

        public List<string> FindCandidatesWhoGotPersonalMandateInKesklinn()
        {
            List<string> candidatesWhoGotPersonalMandateList = new List<string>();
            
            for (int i = 0; i < _totalVotesForCandidatesListAsInt.Count; i++)
            {
                if (_totalVotesForCandidatesListAsInt[i] > _kesklinnQuota)
                    //find candidates who surpassed the quota for Kesklinn
                {
                    candidatesWhoGotPersonalMandateList.Add(_candidatesTotalList[i]);
                    _indexListKesklinn.Add(i);
                }
            }
            return candidatesWhoGotPersonalMandateList;
        }

        public List<string> FindCandidatesWhoGotPersonalMandateInLasnamäe()
        {
            List<string> candidatesWhoGotPersonalMandateList = new List<string>();

            for (int i = 0; i < _lasnaCandidatesTotalList.Count; i++)
            {
                if (_totalLasnaVotesForCandidatesListAsInt[i] > _lasnaQuota)
                    //find candidates who surpassed the quota for Lasnamäe
                {
                    candidatesWhoGotPersonalMandateList.Add(_lasnaCandidatesTotalList[i]);
                    _indexListLasna.Add(i);
                }
            }
            return candidatesWhoGotPersonalMandateList;
        }

        public List<string> CreateAListOfPartiesForCandidatesWhoGotPersonalMandateInKesklinn()
        {
            List<string> successfulCandidatesList = FindCandidatesWhoGotPersonalMandateInKesklinn();
            List<string> partiesListForVerySuccessfulCandidates = new List<string>();

            for (int i = 0; i < successfulCandidatesList.Count; i++)
            {
                partiesListForVerySuccessfulCandidates.Add(_partyNamesInFile2TotalList[_indexListKesklinn[i]]);
            }
            return partiesListForVerySuccessfulCandidates;
        }

        public List<string> CreateAListOfPartiesForCandidatesWhoGotPersonalMandateInLasnamäe()
        {
            List<string> successfulCandidatesList = FindCandidatesWhoGotPersonalMandateInLasnamäe();
            List<string> partiesListForVerySuccessfulCandidates = new List<string>();

            for (int i = 0; i < successfulCandidatesList.Count; i++)
            {
                partiesListForVerySuccessfulCandidates.Add(_partyNamesInFile3TotalList[_indexListLasna[i]]);
            }
            return partiesListForVerySuccessfulCandidates;
        }
        
        public List<int> CreateAListOfVotesForCandidatesWhoGotPersonalMandateInKesklinn()
        {
            List<string> successfulCandidatesList = FindCandidatesWhoGotPersonalMandateInKesklinn();
            List<int> votesForVerySuccessfulCandidatesList = new List<int>();

            for (int i = 0; i < successfulCandidatesList.Count; i++)
            {
                votesForVerySuccessfulCandidatesList.Add(_totalVotesForCandidatesListAsInt[_indexListKesklinn[i]]);
            }
            return votesForVerySuccessfulCandidatesList;
        }

        public List<int> CreateAListOfVotesForCandidatesWhoGotPersonalMandateInLasnamäe()
        {
            List<string> successfulCandidatesList = FindCandidatesWhoGotPersonalMandateInLasnamäe();
            List<int> votesForVerySuccessfulCandidatesList = new List<int>();

            for (int i = 0; i < successfulCandidatesList.Count; i++)
            {
                votesForVerySuccessfulCandidatesList.Add(_totalLasnaVotesForCandidatesListAsInt[_indexListLasna[i]]);
            }
            return votesForVerySuccessfulCandidatesList;
        }

        public void PrintInfoForCandidatesWhoGotPersonalMandateAtKesklinn()
        {
            Console.WriteLine($"Candidates who got personal mandate at Tallinn Kesklinn:");
            List<string> candidatesList = FindCandidatesWhoGotPersonalMandateInKesklinn();
            List<string> partiesList = CreateAListOfPartiesForCandidatesWhoGotPersonalMandateInKesklinn();
            List<int> votesList = CreateAListOfVotesForCandidatesWhoGotPersonalMandateInKesklinn();

            for (int i = 0; i < candidatesList.Count; i++)
            {
                Console.WriteLine($"{candidatesList[i]} ({partiesList[i]}, {votesList[i]} votes)");
            }
        }

        public void PrintInfoForCandidatesWhoGotPersonalMandateAtLasnamäe()
        {
            Console.WriteLine($"Candidates who got personal mandate at Tallinn Lasnamäe:");
            List<string> candidatesList = FindCandidatesWhoGotPersonalMandateInLasnamäe();
            List<string> partiesList = CreateAListOfPartiesForCandidatesWhoGotPersonalMandateInLasnamäe();
            List<int> votesList = CreateAListOfVotesForCandidatesWhoGotPersonalMandateInLasnamäe();

            for (int i = 0; i < candidatesList.Count; i++)
            {
                Console.WriteLine($"{candidatesList[i]} ({partiesList[i]}, {votesList[i]} votes)");
            }
        }

        public void SaveKesklinnUsernamesListToFile(List<string> inputList)
        {
            using (StreamWriter writer = new StreamWriter("usernames_kesklinn.txt"))
            {
                for (int i = 0; i < inputList.Count; i++)
                {
                    writer.WriteLine(inputList[i]);
                }
            }
        }

        public void SaveLasnaUsernamesListToFile(List<string> inputList)
        {
            using (StreamWriter writer = new StreamWriter("usernames_lasna.txt"))
            {
                for (int i = 0; i < inputList.Count; i++)
                {
                    writer.WriteLine(inputList[i]);
                }
            }
        }

        public void CreateAndSaveToFileUsernamesForAllKesklinnCandidates()
        {
            List<string> usernames = new List<string>();

            foreach (string name in _candidatesTotalList)
            {
                string username = "";
                string forenames = "";
                string lastname = "";
                string forenamesForUsername = "";
                string nameWithoutDots = RemoveSpecialCharsFromName(name);
                if (name.Contains(' ')) //entered name has at least one space
                {
                    int index = nameWithoutDots.LastIndexOf(' ');
                    forenames = nameWithoutDots.Substring(0, index);
                    lastname = nameWithoutDots.Substring(index + 1, nameWithoutDots.Length - index - 1);
                    if (forenames.Contains(' '))
                    {
                        string[] forenameParts = forenames.Split(' ');
                        for (int i = 0; i < forenameParts.Length; i++)
                        {
                            if (forenameParts[i].Length > 3)
                            {
                                forenamesForUsername += forenameParts[i].Substring(0, 3);
                                //get first 3 letters of each forename
                            }
                            else
                            {
                                forenamesForUsername += forenameParts[i];
                            }
                        }
                    }
                    else
                    {
                        forenamesForUsername = forenames;
                    }
                    forenamesForUsername = forenamesForUsername.Replace(" ", string.Empty); //remove whitespaces
                    if (forenamesForUsername.Length > 6)
                    {
                        forenamesForUsername = forenamesForUsername.Substring(0, 6); //max 6 chars
                    }
                    if (lastname.Length > 6)
                    {
                        lastname = lastname.Substring(0, 6); //max 6 chars
                    }
                    username = $"{forenamesForUsername}.{lastname}";
                }
                else
                {
                    username = nameWithoutDots;
                    if (username.Length > 6)
                    {
                        username = username.Substring(0, 6);
                    }
                }
                username = username.ToLower();
                username = username.Trim();
                usernames.Add(username);
            }

            var hashset = new HashSet<string>(); //this hashset idea I got from StackOverflow
            for (int i = 0; i < usernames.Count; i++)
            {
                if (!hashset.Add(usernames[i])) //if a duplicate is found
                {
                    usernames[i] = usernames[i].Remove(usernames[i].Length - 1, 1);
                    usernames[i] = String.Join("", usernames[i] + "x");
                    //replaces the last character with "x"
                }
            }
            SaveKesklinnUsernamesListToFile(usernames);
        }

        public void CreateAndSaveToFileUsernamesForAllLasnaCandidates()
        {
            List<string> usernames = new List<string>();

            foreach (string name in _lasnaCandidatesTotalList)
            {
                string username = "";
                string forenames = "";
                string lastname = "";
                string forenamesForUsername = "";
                string nameWithoutDots = RemoveSpecialCharsFromName(name);
                if (name.Contains(' ')) //entered name has at least one space
                {
                    int index = nameWithoutDots.LastIndexOf(' ');
                    forenames = nameWithoutDots.Substring(0, index);
                    lastname = nameWithoutDots.Substring(index + 1, nameWithoutDots.Length - index - 1);
                    if (forenames.Contains(' '))
                    {
                        string[] forenameParts = forenames.Split(' ');
                        for (int i = 0; i < forenameParts.Length; i++)
                        {
                            if (forenameParts[i].Length > 3)
                            {
                                forenamesForUsername += forenameParts[i].Substring(0, 3);
                                //get first 3 letters of each forename
                            }
                            else
                            {
                                forenamesForUsername += forenameParts[i];
                            }
                        }
                    }
                    else
                    {
                        forenamesForUsername = forenames;
                    }
                    forenamesForUsername = forenamesForUsername.Replace(" ", string.Empty); //remove whitespaces
                    if (forenamesForUsername.Length > 6)
                    {
                        forenamesForUsername = forenamesForUsername.Substring(0, 6); //max 6 chars
                    }
                    if (lastname.Length > 6)
                    {
                        lastname = lastname.Substring(0, 6); //max 6 chars
                    }
                    username = $"{forenamesForUsername}.{lastname}";
                }
                else
                {
                    username = nameWithoutDots;
                    if (username.Length > 6)
                    {
                        username = username.Substring(0, 6);
                    }
                }
                username = username.ToLower();
                username = username.Trim();
                usernames.Add(username);
            }

            var hashset = new HashSet<string>(); //this hashset idea I got from StackOverflow
            for (int i = 0; i < usernames.Count; i++)
            {
                if (!hashset.Add(usernames[i])) //if a duplicate is found
                {
                    usernames[i] = usernames[i].Remove(usernames[i].Length - 1, 1);
                    usernames[i] = String.Join("", usernames[i] + "x");
                    //replaces the last character with "x"
                }
            }
            SaveLasnaUsernamesListToFile(usernames);
        }
    }
}