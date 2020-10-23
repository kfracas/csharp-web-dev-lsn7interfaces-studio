using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            List<Data> cdData = new List<Data>();
            Data musicData1 = new Data("Tearin' Up My Heart", 100);
            cdData.Add(musicData1);
            CD cd1 = new CD("NSYNC", "CD-DA", 700, cdData);

            List<Data> dvdData = new List<Data>();
            Data movieData1 = new Data("Chapter 10: Pirate Ship", 300);
            dvdData.Add(movieData1);
            DVD dvd1 = new DVD("The Goonies", "DVD-RAM", 5000, dvdData);

            // TODO: Call each CD and DVD method to verify that they work as expected.

            Data musicData2 = new Data("Bye Bye Bye", 100);
            cd1.SpinDisc();
            cd1.StoreData(musicData2);
            cd1.WriteData();
            cd1.ReadData();
            cd1.ReportInfo();

            Data movieData2 = new Data("Chapter 1: Jail Break", 300);
            dvd1.SpinDisc();
            dvd1.StoreData(movieData2);
            dvd1.WriteData();
            dvd1.ReadData();
            dvd1.ReportInfo();
        }
    }
}
