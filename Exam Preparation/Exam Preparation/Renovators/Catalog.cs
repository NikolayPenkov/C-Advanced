using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        private string name;
        private int neededRenovators;
        private string project;

        public Catalog(string name, int neededRenovators, string project)
        {
            renovators = new List<Renovator>();
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int NeededRenovators
        {
            get { return neededRenovators; }
            set { neededRenovators = value; }
        }
        public string Project
        {
            get { return project; }
            set { project = value; }  
        }

        public int Count { get { return renovators.Count; } }
        public string AddRenovator(Renovator renovator)
        {
            if (String.IsNullOrEmpty(renovator.Name) && String.IsNullOrEmpty(renovator.Type))
            {
               return "Invalid renovator's information.";
            }
            if (renovators.Count >= neededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }
        public bool RemoveRenovator(string name)
        {
            Renovator renovator = renovators.FirstOrDefault(x => x.Name == name);

            return renovators.Remove(renovator);
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            List<Renovator> leftRenovators = renovators.Where(r => r.Type != type).ToList();
            int removedCount = renovators.Count - leftRenovators.Count;
            renovators = leftRenovators;

            if (removedCount > 0)
            {
                return removedCount;
            }
            else
            {
                return 0;
            }
        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = renovators.FirstOrDefault(x => x.Name == name);
            if (renovator != null)
            {
             renovator.Hired = true;
            }
            return renovator;
        }
        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> payRenovators = renovators.Where(x => x.Days >= days).ToList();
            return payRenovators;
        }

        public string Report()
        {
            List<Renovator> report = new List<Renovator>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}");
            foreach (var r in renovators)
            {
                if (r.Hired == false)
                {
                    report.Add(r);
                }
            }
           
            foreach (var renovator in report)
            {
                sb.AppendLine(renovator.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
