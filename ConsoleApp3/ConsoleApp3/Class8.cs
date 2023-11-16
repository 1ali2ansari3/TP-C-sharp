using System;


namespace Chap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe employe1 = new Employe(1, "Ali", "Salem", 12000);
            Employe employe2 = new Employe(2, "Hassan", "Mohammed", 10000);
            Employe employe3 = new Employe(3, "Omar", "Karim", 15000);

            PiloteLigne pilote1 = new PiloteLigne(4, "Morad", "Lotfi", 25000, "Commandant", 3500);
            PiloteLigne pilote2 = new PiloteLigne(5, "Amine", "Rachid", 22000, "Capitaine", 2500);

            Steward steward1 = new Steward(6, "Fatima", "Ali", 13000, "Féminin");
            Steward steward2 = new Steward(7, "Yassine", "Karim", 11000, "Masculin");
            Steward steward3 = new Steward(8, "Mouna", "Nadia", 12000, "Féminin");

            List<Employe> employes = new List<Employe>();
            employes.Add(employe1);
            employes.Add(employe2);
            employes.Add(employe3);
            employes.Add(pilote1);
            employes.Add(pilote2);
            employes.Add(steward1);
            employes.Add(steward2);
            employes.Add(steward3);

            foreach (Employe employe in employes)
            {
                Console.WriteLine(employe.Presentation());
            }

            double salaireTotal = 0;
            foreach (Employe employe in employes)
            {
                salaireTotal += employe.GetSalaire();
            }
            Console.WriteLine($"Le salaire total de tous les employés est de {salaireTotal} DH.");

            string fileName = "C:\\Users\\1ali2\\Desktop\\C sharp\\ConsoleApp3/employes.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Employe employe in employes)
                {
                    writer.WriteLine(employe.Presentation());
                }
            }
            Console.WriteLine($"Les données ont été enregistrées dans le fichier {fileName}.");
        }
    }
}