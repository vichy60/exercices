﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loginCorrect = false;
            bool mdpCorrect = false;

            while (!loginCorrect)
            {
                Console.WriteLine("veuillez saisir votre Login ! (5 caracteres mini");
                string login = Console.ReadLine();

                try
                {
                    VérifLogin(login, out loginCorrect);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);

                }
            }


            while (!mdpCorrect)
            {
                Console.WriteLine("veuillez saisir votre mot de passe! (entre 6 et 12 caracteres et ne commence ni ne fini par un espace au premier et dernier) ");
                string mdp = Console.ReadLine();

                try
                {
                    VérifMdp(mdp, out mdpCorrect);

                }
                catch (FormatException e)
                {
                    
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Votre compte a bien été créé. Un message vient de vous être envoyé");
            Console.ReadKey();


        }

        static void VérifLogin(string log, out bool loginCorrect)
        {
            if (log.Length < 5)
            {
                throw new FormatException("login trop petit!( min 5 caracteres!)");
            }
            loginCorrect = true;


        }

        static void VérifMdp(string mdp, out bool mdpCorrect)
        {
            if (mdp.Length < 6)
            {
                throw new FormatException("mot de passe trop petit!( 6 caracteres mini!)");
            }

            if (mdp.Length > 12)
            {
                throw new FormatException("mot de passe trop grand!( 12 caracteres maxi!)");
            }
            if (mdp[0] == ' ')
            {
                throw new FormatException("mot de passe erroné!( pas d'espace au début svp!)");
            }
            if (mdp[mdp.Length - 1] == ' ')
            {
                throw new FormatException("mot de passe erroné!( pas d'espace à la fin svp!)");
            }
            mdpCorrect = true;
        }

    }

}
