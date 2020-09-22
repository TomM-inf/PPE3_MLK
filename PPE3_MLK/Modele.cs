using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PPE3_MLK
{
    class Modele
    {
        private static connectProjetGSB maConnexion;
        private static Visiteur visiteurConnecte;
        private static bool connexionValide;

        public static Visiteur VisiteurConnecte { get => visiteurConnecte; set => visiteurConnecte = value; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }

        public static void init()
        {
            maConnexion = new connectProjetGSB();
        }

        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static string validConnexion(string id, string mp)
        {
            Console.WriteLine(id);
            Console.WriteLine(mp);
            Console.WriteLine(GetMd5Hash(mp));
            string message = "";
            try
            {
                VisiteurConnecte = ((Visiteur)VisiteurParIdentifiant(id));

            }
            catch (Exception ex)
            {
                message = "Identifiant ou mot de passe incorrect"; //si ça ne marche pas alors Identifiant incorrect
            }
            if(VisiteurConnecte != null) //si l'identifiant à été reconnu
            {
                if(mp.Length == 0)
                {
                    message = "Merci de saisir un mot de passe";
                }
                else
                {
                    if(VisiteurConnecte.password.Equals(GetMd5Hash(mp)) == true) //si les MDP correspondent
                    {
                        ConnexionValide = true;
                        message = "Connexion valide";
                    }
                    else
                    {
                        message = "Identifiant ou mot de passe incorrect";
                    }
                }
            }
            return message;
        }

        public static Object VisiteurParIdentifiant(string identifiant)
        {
            var LQuery = maConnexion.Visiteur.ToList()
                .Where(x => x.identifiant == identifiant);
            return LQuery.ToList()[0];
        }
    }
}
