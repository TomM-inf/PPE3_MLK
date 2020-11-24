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

        public static string nomVisiteur()  //pour afficher le nom et le prénom du visiteur.
        {
            string vretour="";
            vretour = VisiteurConnecte.nom + " " + VisiteurConnecte.prenom;
            return vretour;
        }

        public static string IDVisiteur()
        {
            string vretour = "";
            vretour = VisiteurConnecte.idVisiteur;
            return vretour;

        }

        

        public static List<fichefrais> ListeFiche() //la liste de fiches pour l'afficher ensuite.
        {
            return maConnexion.fichefrais.Where(x => x.idVisiteur == visiteurConnecte.idVisiteur).ToList();
        }

        public static List<LigneFraisForfait> ListeLigneFraisForfait() //on lie la table LigneFraisForfait
        {
            return maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == visiteurConnecte.idVisiteur).ToList();
        }

        public static List<FraisForfait> ListeFraisForfait() //on lie la table FraisForfait
        {
            return maConnexion.FraisForfait.ToList();
        }
        public static Object rembouMoisPasDep(string id,string mois) // objet batard qui sert SEULEMENT a la visualisation d'une fiche cloturée 
        {
           
            
 
            var LQuery = maConnexion.LigneFraisForfait
                .Where(x => x.idVisiteur == id && x.mois==mois && x.FraisForfait.deplacement==false).Select(x=> new { x.FraisForfait.libelle, x.quantite, x.FraisForfait.montant,total= x.FraisForfait.montant * x.quantite, x.idFraisForfait }) ;


            return LQuery.ToList();
        }

        public static Object FraisHorsForfait(string id, string mois)
        {
           var LQuery =  maConnexion.LigneFraisHorsForfait.Where(x => x.idVisiteur == visiteurConnecte.idVisiteur).ToList()
                .Where(x => x.idVisiteur == id && x.mois == mois);

            return LQuery;
        }

    }

}
