using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name{ get; set; }
        public string DiscType { get; set; }
        public double StorageCapacity { get; set; }
        public double StorageUsed { get; set; } = 0;
        public List<Data> Contents { get; set; }
        public bool DiscReadable { get; set; } = false;
        public BaseDisc(string name, string discType, double storageCapacity, List<Data> contents)
        {
            Name = name;
            DiscType = discType;
            StorageCapacity = storageCapacity;
            Contents = contents;
        }
        public string StoreData(Data data)
        {
            if (StorageUsed + data.Size > StorageCapacity)
            {
                return "Not enough storage capacity.";
            } else
            {
                Contents.Add(data);
                StorageUsed += data.Size;
                return "Data has been added.";
            }
        }
        public void WriteData()
        {
            DiscReadable = true;
        }
        public void ReadData()
        {
            foreach (Data data in Contents)
            {
                Console.WriteLine(data);
            }
        }
        public void ReportInfo()
        {
            string discContents = "";
            foreach (Data data in Contents)
            {
                if (Contents.IndexOf(data) == Contents.Count - 1)
                {
                    discContents += data.Name;
                } else
                {
                    discContents += data.Name + ", ";
                }
            }
            Console.WriteLine("Name: " + Name + "\n" + "Disc Type: " + DiscType + "\n" + "Storage Capacity: " + StorageCapacity + " GB" + "\n" + "Contents: " + discContents + "\n");
        }
        public override string ToString()
        {
            return "Name: " + Name + "\n" + "Disc Type: " + DiscType + "\n" + "Storage Capacity: " + StorageCapacity + " GB" + "\n" + "Contents: " + Contents + "\n";
        }
    }
}
