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
        private static GSB2_GroupeMLKEntities maConnexion;
        private static Visiteur visiteurConnecte;
        private static bool connexionValide;
        private static List<Visiteur> malist;
        private static int actionGestionRapport;
        private static RAPPORT rapportChoisi;

        public static int ActionGestionRapport { get => actionGestionRapport; set => actionGestionRapport = value; }
        public static RAPPORT CompositeurChoisi { get => rapportChoisi; set => rapportChoisi = value; }

        public static Visiteur VisiteurConnecte { get => visiteurConnecte; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }

        public static void init()
        {
            maConnexion = new GSB2_GroupeMLKEntities();
            malist = maConnexion.Visiteur.ToList();
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
            string message = "";
            try
            {
                visiteurConnecte = (Visiteur)VisiteurParIdentifiant(id);

            }
            catch (Exception ex)
            {
                message = "Identifiant ou mot de passe incorrect"; //si ça ne marche pas alors Identifiant incorrect
                Console.WriteLine(ex);
            }
            if (VisiteurConnecte != null) //si l'identifiant à été reconnu
            {
                if (mp.Length == 0)
                {
                    message = "Merci de saisir un mot de passe";
                }
                else
                {

                    if (VisiteurConnecte.password.Equals(GetMd5Hash(mp)) == true) //si les MDP correspondent
                    {
                        ConnexionValide = true;
                        message = "valide";
                    }
                    else
                    {
                        message = "Identifiant ou mot de passe incorrect";
                    }
                }
            }
            return message;
        }

        public static Object VisiteurParIdentifiant(string id)
        {
            Object vretour = null;
            var LQuery = maConnexion.Visiteur.ToList()
                .Where(x => x.identifiant == id);
            if (LQuery.ToList().Count() == 1)
            { vretour = LQuery.ToList()[0]; }
            return vretour;
        }
        public static object RapportParMedecin(int idMedecin)
        {
            var lQuery = maConnexion.RAPPORT.ToList()
                .Where(x => x.idMedecin == idMedecin)
                .Select(x => new { x.idRapport, x.dateRapport, x.idMedecin, x.idMotif, x.idVisiteur })//nom prenom medecin pas id pareille motif et client 
                .OrderBy(x => x.dateRapport);
            return lQuery.ToList();
        }
        public static Object listeMedecin()
        {
            return maConnexion.MEDECIN.ToList();
        }
        public static bool AjoutRapport(int idRapport, DateTime dateRapport, int idMotif, string bilan, string idVisiteur, int idMedecin)
        {
            bool vretour = true;
            try
            {
                rapportChoisi = new RAPPORT();
                rapportChoisi.idRapport = idRapport;
                rapportChoisi.dateRapport = dateRapport;
                rapportChoisi.idMotif = idMotif;
                rapportChoisi.bilan = bilan;
                rapportChoisi.idVisiteur = idVisiteur;
                rapportChoisi.idMedecin = idMedecin;
                maConnexion.RAPPORT.Add(rapportChoisi);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
        public static void getRapportParNum(int idRapport)
        {
            var LQuery = maConnexion.RAPPORT.ToList()
                           .Where(x => x.idRapport == idRapport);
            rapportChoisi = (RAPPORT)LQuery.ToList()[0];
        }

    }
}
