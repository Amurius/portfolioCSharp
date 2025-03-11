using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Portfolio
{
    public partial class enterPC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Content

            #region Projets
            int i = 0;
            Panel pnlProjet1 = new Panel();
            Panel pnlProjetGauche = new Panel();
            Label lbProjet1 = new Label();
            Panel pnlDescDemande = new Panel();
            Label lbTitreDescDemande = new Label();
            Label lbDescDemande = new Label();
            Panel pnlInfos = new Panel();
            Label lbTitreInfos = new Label();
            Label lbInfos = new Label();
            Panel pnlProjetDroit = new Panel();
            Panel pnlProjetsOutils = new Panel();
            Label lbProjetTitreOutils = new Label();
            Label lbProjetOutils = new Label();
            HyperLink hlNext = new HyperLink();
            HyperLink hlPrecedent = new HyperLink();
            Panel pnlDocumentP1 = new Panel();
            Panel pnlDocumentPX = new Panel();

            hlNext = new HyperLink();
            hlNext.ID = "hlNext";
            hlNext.Text = "〉";
            hlNext.Style.Add("justify-self", "end");
            hlNext.Style.Add("padding", "24px 0px 24px 14px");

            hlPrecedent = new HyperLink();
            hlPrecedent.ID = "hlPrecedent";
            hlPrecedent.Text = "\u3008";
            hlPrecedent.Style.Add("justify-self", "start");
            hlPrecedent.Style.Add("padding", "24px 14px 24px 0px");

            for (i = 0; i < 8; i++)
            {
                pnlProjet1 = new Panel();
                pnlProjet1.ID = "pnlProjet" + i;
                pnlProjet1.CssClass = "pnlProjets";
                pnlProjet1.Width = Unit.Percentage(100);
                pnlProjet1.Height = Unit.Percentage(100);
                pnlProjet1.Style.Add("visibility", "hidden");
                pnlProjet1.Style.Add("display", "flex");
                pnlProjet1.Style.Add("position", "absolute");
                pnlProjet1.Style.Add("transform", "scale(0.05)");
                pnlProjet1.Style.Add("opacity", "0");
                pnlProjet1.Style.Add("top", "50%");
                pnlProjet1.Style.Add("background-repeat", "no-repeat");
                pnlProjet1.Style.Add("background-size", "cover");
                pnlProjet1.Style.Add("transition", "1s");

                switch (i)
                {
                    case 0:
                        for (int k = 0; k < 9; k++)
                        {
                            pnlDocumentPX = new Panel();
                            pnlDocumentPX.ID = "pnlDocument" + k + "P" + i;
                            pnlDocumentPX.CssClass = "pnlDocumentsP" + i;
                            pnlDocumentPX.Width = Unit.Percentage(0);
                            pnlDocumentPX.Height = Unit.Percentage(100);
                            pnlDocumentPX.Style.Add("position", "absolute");
                            pnlDocumentPX.Style.Add("display", "flex");
                            pnlDocumentPX.Style.Add("transition", "1s");
                            pnlDocumentPX.Style.Add("left", "100%");
                            pnlDocumentPX.Style.Add("overflow", "hidden");
                            pnlDocumentPX.Style.Add("font-family", "'Computer'");

                            pnlProjetGauche = new Panel();
                            pnlProjetGauche.Width = Unit.Percentage(100);
                            pnlProjetGauche.Height = Unit.Percentage(100);
                            pnlProjetGauche.Style.Add("position", "relative");
                            pnlProjetGauche.Style.Add("display", "flex");

                            pnlProjetDroit = new Panel();
                            pnlProjetDroit.Width = Unit.Percentage(100);
                            pnlProjetDroit.Height = Unit.Percentage(100);
                            pnlProjetDroit.Style.Add("position", "relative");
                            pnlProjetDroit.Style.Add("display", "flex");

                            lbProjet1 = new Label();
                            lbProjet1.CssClass = "presentationProjet";
                            lbProjet1.Text = "Outil de gestion pour des écrans";
                            lbProjet1.Style.Add("top", "7.4%");
                            lbProjet1.Style.Add("left", "10%");
                            lbProjet1.Style.Add("font-size", "32px");
                            lbProjet1.Style.Add("font-weight", "bold");

                            Panel pnlCompetences = new Panel();
                            pnlCompetences.CssClass = "presentationProjet";
                            pnlCompetences.Style.Add("top", "7.4%");
                            pnlCompetences.Style.Add("left", "10%");
                            Label lbCompetences = new Label();
                            lbCompetences.CssClass = "sousTitre";
                            Label lbCompetence = new Label();
                            lbCompetence.Style.Add("font-size", "20px");
                            pnlProjetGauche.Controls.Add(lbProjet1);
                            Panel pnlImage = new Panel();
                            pnlImage.CssClass = "imageProjet";
                            pnlImage.Style.Add("width", "160%");
                            pnlImage.Style.Add("height", "-webkit-fill-available");
                            pnlImage.Style.Add("top", "25%");
                            pnlImage.Style.Add("left", "15%");
                            switch (k)
                            {
                                case 0:
                                    lbCompetences.Text = "Certains ecrans pour exemple :";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlDocumentPX.Style.Add("background-image", "url('/Images/siteGestionEcrans/ecrans1.jpg')");
                                    break;
                                case 1:
                                    lbCompetences.Text = "Gérer le patrimoine informatique :";
                                    lbCompetence.Text = "Exploiter des référentiels, normes et standards adoptés par le prestataire informatique";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage.BackImageUrl = "/Images/siteGestionEcrans/charteCouleurs.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);
                                    break;
                                case 2:
                                    lbCompetences.Text = "Gérer le patrimoine informatique :";
                                    lbCompetence.Text = "Exploiter des référentiels, normes et standards adoptés par le prestataire informatique";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage.BackImageUrl = "/Images/siteGestionEcrans/charteIcons.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);
                                    break;
                                case 3:
                                    lbCompetences.Text = "Répondre aux incidents et aux demandes d’assistance et d’évolution";
                                    lbCompetence.Text = "Collecter, suivre et orienter des demandes et Traiter des demandes concernant les services réseau et système, applicatifs";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/siteGestionEcrans/demandeReseau.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "-webkit-fill-available");
                                    pnlImage.Style.Add("top", "40%");
                                    pnlProjetGauche.Controls.Add(pnlImage);
                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/siteGestionEcrans/demandeReseau2.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "-webkit-fill-available");
                                    pnlImage.Style.Add("top", "40%");
                                    pnlProjetDroit.Controls.Add(pnlImage);
                                    break;
                                case 4:
                                    lbCompetences.Text = "Répondre aux incidents et aux demandes d’assistance et d’évolution";
                                    lbCompetence.Text = "Traiter des demandes concernant les applications";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage.BackImageUrl = "/Images/siteGestionEcrans/demandeAide.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);
                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/siteGestionEcrans/demandeAide2.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "-webkit-fill-available");
                                    pnlImage.Style.Add("top", "25%");
                                    pnlProjetDroit.Controls.Add(pnlImage);
                                    break;
                                case 5:
                                    lbCompetences.Text = "Travailler en mode projet";
                                    lbCompetence.Text = "Analyser les objectifs et les modalités d'organisation d'un projet";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage.BackImageUrl = "/Images/siteGestionEcrans/objectif.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);
                                    break;
                                case 6:
                                    lbCompetences.Text = "Travailler en mode projet";
                                    lbCompetence.Text = "Planifier les activités";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage.BackImageUrl = "/Images/siteGestionEcrans/projetEtapes.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);
                                    break;
                                case 7:
                                    lbCompetences.Text = "Travailler en mode projet";
                                    lbCompetence.Text = "Déployer un service";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage.BackImageUrl = "/Images/siteGestionEcrans/deployerService.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);
                                    break;
                                case 8:
                                    lbCompetences.Text = "Organiser son développement professionnel";
                                    lbCompetence.Text = "Mettre en place son environnement d’apprentissage personnel";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlDocumentPX.BackImageUrl = "/Images/siteGestionEcrans/notion.png";
                                    pnlImage.BackImageUrl = "/Images/siteGestionEcrans/favoris.png";
                                    pnlImage.Style.Add("width", "60%");
                                    pnlImage.Style.Add("left", "25%");
                                    pnlImage.Style.Add("top", "58%");
                                    pnlProjetDroit.Controls.Add(pnlImage);
                                    break;

                            }
                            pnlProjetDroit.Controls.Add(pnlCompetences);
                            pnlDocumentPX.Style.Add("background-color", "white");

                            pnlDocumentPX.Controls.Add(pnlProjetGauche);
                            pnlDocumentPX.Controls.Add(pnlProjetDroit);
                            content.Controls.Add(pnlDocumentPX);
                        }
                        break;
                    case 1:
                        for (int k = 0; k < 2; k++)
                        {
                            pnlDocumentPX = new Panel();
                            pnlDocumentPX.ID = "pnlDocument" + k + "P" + i;
                            pnlDocumentPX.CssClass = "pnlDocumentsP" + i;
                            pnlDocumentPX.Width = Unit.Percentage(0);
                            pnlDocumentPX.Height = Unit.Percentage(100);
                            pnlDocumentPX.Style.Add("position", "absolute");
                            pnlDocumentPX.Style.Add("display", "flex");
                            pnlDocumentPX.Style.Add("transition", "1s");
                            pnlDocumentPX.Style.Add("left", "100%");
                            pnlDocumentPX.Style.Add("overflow", "hidden");
                            pnlDocumentPX.Style.Add("font-family", "'Computer'");

                            pnlProjetGauche = new Panel();
                            pnlProjetGauche.Width = Unit.Percentage(50);
                            pnlProjetGauche.Height = Unit.Percentage(100);
                            pnlProjetGauche.Style.Add("position", "relative");
                            pnlProjetGauche.Style.Add("display", "flex");

                            pnlProjetDroit = new Panel();
                            pnlProjetDroit.Width = Unit.Percentage(50);
                            pnlProjetDroit.Height = Unit.Percentage(100);
                            pnlProjetDroit.Style.Add("position", "relative");
                            pnlProjetDroit.Style.Add("display", "flex");

                            lbProjet1 = new Label();
                            lbProjet1.CssClass = "presentationProjet";
                            lbProjet1.Text = "Sous-partie outil de gestion";
                            lbProjet1.Style.Add("top", "7.4%");
                            lbProjet1.Style.Add("left", "10%");
                            lbProjet1.Style.Add("font-size", "32px");
                            lbProjet1.Style.Add("font-weight", "bold");
                            pnlProjetGauche.Controls.Add(lbProjet1);

                            Panel pnlCompetences = new Panel();
                            pnlCompetences.CssClass = "presentationProjet";
                            pnlCompetences.Style.Add("top", "7.4%");
                            pnlCompetences.Style.Add("left", "10%");
                            Label lbCompetences = new Label();
                            lbCompetences.CssClass = "sousTitre";
                            Label lbCompetence = new Label();
                            lbCompetence.Style.Add("font-size", "20px");
                            pnlProjetGauche.Controls.Add(lbProjet1);
                            Panel pnlImage = new Panel();
                            switch (k)
                            {
                                case 0:
                                    lbCompetences.Text = "Gérer le patrimoine informatique :";
                                    lbCompetence.Text = "Recenser et identifier les ressources numériques";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);


                                    pnlImage = new Panel();
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "100%");
                                    pnlImage.Style.Add("top", "25%");
                                    //pnlImage.Style.Add("left", "0%");
                                    pnlImage.BackImageUrl = "/Images/Recensement/recensement1.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);

                                    pnlImage = new Panel();
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "100%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.BackImageUrl = "/Images/Recensement/recensement2.png";
                                    pnlProjetDroit.Controls.Add(pnlImage);
                                    break;
                                case 1:
                                    lbCompetences.Text = "Répondre aux incidents et aux demandes d’assistance et d’évolution";
                                    lbCompetence.Text = "Vérifier les conditions de continuité d'un service informatique";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlImage = new Panel();
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "100%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("left", "20%");
                                    pnlImage.BackImageUrl = "/Images/Recensement/versionRecensement.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);

                                    break;

                            }
                            pnlProjetDroit.Controls.Add(pnlCompetences);
                            pnlDocumentPX.Style.Add("background-color", "white");

                            pnlDocumentPX.Controls.Add(pnlProjetGauche);
                            pnlDocumentPX.Controls.Add(pnlProjetDroit);
                            content.Controls.Add(pnlDocumentPX);
                        }
                        break;
                    case 2:
                        for (int k = 0; k < 3; k++)
                        {
                            pnlDocumentPX = new Panel();
                            pnlDocumentPX.ID = "pnlDocument" + k + "P" + i;
                            pnlDocumentPX.CssClass = "pnlDocumentsP" + i;
                            pnlDocumentPX.Width = Unit.Percentage(0);
                            pnlDocumentPX.Height = Unit.Percentage(100);
                            pnlDocumentPX.Style.Add("position", "absolute");
                            pnlDocumentPX.Style.Add("display", "flex");
                            pnlDocumentPX.Style.Add("transition", "1s");
                            pnlDocumentPX.Style.Add("left", "100%");
                            pnlDocumentPX.Style.Add("overflow", "hidden");
                            pnlDocumentPX.Style.Add("font-family", "'Computer'");

                            pnlProjetGauche = new Panel();
                            pnlProjetGauche.Width = Unit.Percentage(50);
                            pnlProjetGauche.Height = Unit.Percentage(100);
                            pnlProjetGauche.Style.Add("position", "relative");
                            pnlProjetGauche.Style.Add("display", "flex");

                            pnlProjetDroit = new Panel();
                            pnlProjetDroit.Width = Unit.Percentage(50);
                            pnlProjetDroit.Height = Unit.Percentage(100);
                            pnlProjetDroit.Style.Add("position", "relative");
                            pnlProjetDroit.Style.Add("display", "flex");

                            lbProjet1 = new Label();
                            lbProjet1.CssClass = "presentationProjet";
                            lbProjet1.Text = "Outil de gestion QRCode";
                            lbProjet1.Style.Add("top", "7.4%");
                            lbProjet1.Style.Add("left", "10%");
                            lbProjet1.Style.Add("font-size", "32px");
                            lbProjet1.Style.Add("font-weight", "bold");
                            pnlProjetGauche.Controls.Add(lbProjet1);

                            Panel pnlCompetences = new Panel();
                            pnlCompetences.CssClass = "presentationProjet";
                            pnlCompetences.Style.Add("top", "7.4%");
                            pnlCompetences.Style.Add("left", "10%");
                            Label lbCompetences = new Label();
                            lbCompetences.CssClass = "sousTitre";
                            Label lbCompetence = new Label();
                            lbCompetence.Style.Add("font-size", "20px");
                            pnlProjetGauche.Controls.Add(lbProjet1);
                            switch (k)
                            {
                                case 0:
                                    lbCompetences.Text = "Gérer le patrimoine informatique :";
                                    lbCompetence.Text = "Recenser et identifier les ressources numériques";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    Panel pnlImage = new Panel();

                                    pnlImage = new Panel();
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "160%");
                                    pnlImage.Style.Add("height", "80%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("left", "5%");
                                    pnlImage.BackImageUrl = "/Images/DDEQRCODE/recenscerProcess.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);

                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/DDEQRCODE/chosesAGarder.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "100%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("left", "3%");
                                    pnlProjetDroit.Controls.Add(pnlImage);
                                    break;
                                case 1:
                                    lbCompetences.Text = "Gérer le patrimoine informatique :";
                                    lbCompetence.Text = "Exploiter des référentiels, normes et standards adoptés par le prestataire informatique";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);
                                    pnlImage = new Panel();
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "-webkit-fill-available");
                                    pnlImage.Style.Add("background-repeat", "no-repeat");
                                    pnlImage.Style.Add("background-size", "contain");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("left", "10%");
                                    pnlImage.Style.Add("position", "absolute");
                                    pnlImage.BackImageUrl = "/Images/siteGestionEcrans/charteCouleurs.png";
                                    pnlDocumentPX.Controls.Add(pnlImage);
                                    break;
                                case 2:
                                    lbCompetences.Text = "Répondre aux incidents et aux demandes d’assistance et d’évolution";
                                    lbCompetence.Text = "Traiter les demandes concernant les applications";
                                    pnlCompetences.Controls.Add(lbCompetences);

                                    pnlImage = new Panel();
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "140%");
                                    pnlImage.Style.Add("height", "70%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("left", "15%");
                                    pnlImage.BackImageUrl = "/Images/DDEQRCODE/ancienLook.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);

                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/DDEQRCODE/app.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "75%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("left", "15%");
                                    pnlProjetDroit.Controls.Add(pnlImage);
                                    break;

                            }
                            pnlProjetDroit.Controls.Add(pnlCompetences);
                            pnlDocumentPX.Style.Add("background-color", "white");

                            pnlDocumentPX.Controls.Add(pnlProjetGauche);
                            pnlDocumentPX.Controls.Add(pnlProjetDroit);
                            content.Controls.Add(pnlDocumentPX);
                        }
                        break;
                    case 3:
                        for (int k = 0; k < 3; k++)
                        {
                            pnlDocumentPX = new Panel();
                            pnlDocumentPX.ID = "pnlDocument" + k + "P" + i;
                            pnlDocumentPX.CssClass = "pnlDocumentsP" + i;
                            pnlDocumentPX.Width = Unit.Percentage(0);
                            pnlDocumentPX.Height = Unit.Percentage(100);
                            pnlDocumentPX.Style.Add("position", "absolute");
                            pnlDocumentPX.Style.Add("display", "flex");
                            pnlDocumentPX.Style.Add("transition", "1s");
                            pnlDocumentPX.Style.Add("left", "100%");
                            pnlDocumentPX.Style.Add("overflow", "hidden");
                            pnlDocumentPX.Style.Add("font-family", "'Computer'");

                            pnlProjetGauche = new Panel();
                            pnlProjetGauche.Width = Unit.Percentage(50);
                            pnlProjetGauche.Height = Unit.Percentage(100);
                            pnlProjetGauche.Style.Add("position", "relative");
                            pnlProjetGauche.Style.Add("display", "flex");

                            pnlProjetDroit = new Panel();
                            pnlProjetDroit.Width = Unit.Percentage(50);
                            pnlProjetDroit.Height = Unit.Percentage(100);
                            pnlProjetDroit.Style.Add("position", "relative");
                            pnlProjetDroit.Style.Add("display", "flex");

                            lbProjet1 = new Label();
                            lbProjet1.CssClass = "presentationProjet";
                            lbProjet1.Text = "Espace de rencontre entre créateurs de contenu et entreprises";
                            lbProjet1.Style.Add("top", "7.4%");
                            lbProjet1.Style.Add("left", "10%");
                            lbProjet1.Style.Add("font-size", "32px");
                            lbProjet1.Style.Add("font-weight", "bold");
                            pnlProjetGauche.Controls.Add(lbProjet1);

                            Panel pnlCompetences = new Panel();
                            pnlCompetences.CssClass = "presentationProjet";
                            pnlCompetences.Style.Add("top", "7.4%");
                            pnlCompetences.Style.Add("left", "10%");
                            Label lbCompetences = new Label();
                            lbCompetences.CssClass = "sousTitre";
                            Label lbCompetence = new Label();
                            lbCompetence.Style.Add("font-size", "20px");
                            pnlProjetGauche.Controls.Add(lbProjet1);
                            Panel pnlImage = new Panel();
                            switch (k)
                            {
                                case 0:
                                    lbCompetences.Text = "Travailler en mode projet";
                                    lbCompetence.Text = "Analyser les objectifs et les modalités d’organisation d’un projet";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage = new Panel();
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "100%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.BackImageUrl = "/Images/AP3/analyseBesoin.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);

                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/AP3/objectif.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "100%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlProjetDroit.Controls.Add(pnlImage);
                                    break;
                                case 1:
                                    lbCompetences.Text = "Travailler en mode projet";
                                    lbCompetence.Text = "Planifier les activités";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/AP3/ganttReact.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "-webkit-fill-available");
                                    pnlImage.Style.Add("background-repeat", "no-repeat");
                                    pnlImage.Style.Add("background-size", "contain");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("position", "absolute");
                                    pnlDocumentPX.Controls.Add(pnlImage);
                                    break;
                                //case 2:
                                //    lbCompetences.Text = "Mettre à disposition des utilisateurs un service informatique";
                                //    lbCompetence.Text = "Réaliser les tests d’intégration et d’acceptation d’un service";
                                //    pnlCompetences.Controls.Add(lbCompetences);
                                //    pnlCompetences.Controls.Add(lbCompetence);
                                //    break;
                                //case 3:
                                //    lbCompetences.Text = "Mettre à disposition des utilisateurs un service informatique";
                                //    lbCompetence.Text = "Déployer un service";
                                //    pnlCompetences.Controls.Add(lbCompetences);
                                //    pnlCompetences.Controls.Add(lbCompetence);
                                //    break;
                                case 2:
                                    lbCompetences.Text = "Mettre à disposition des utilisateurs un service informatique";
                                    lbCompetence.Text = "Accompagner les utilisateurs dans la mise en place d’un service";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage = new Panel();
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "100%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.BackImageUrl = "/Images/AP3/docUtil.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);
                                    break;

                            }
                            pnlProjetDroit.Controls.Add(pnlCompetences);
                            pnlDocumentPX.Style.Add("background-color", "white");

                            pnlDocumentPX.Controls.Add(pnlProjetGauche);
                            pnlDocumentPX.Controls.Add(pnlProjetDroit);
                            content.Controls.Add(pnlDocumentPX);
                        }
                        break;
                    case 4:
                        for (int k = 0; k < 3; k++)
                        {
                            pnlDocumentPX = new Panel();
                            pnlDocumentPX.ID = "pnlDocument" + k + "P" + i;
                            pnlDocumentPX.CssClass = "pnlDocumentsP" + i;
                            pnlDocumentPX.Width = Unit.Percentage(0);
                            pnlDocumentPX.Height = Unit.Percentage(100);
                            pnlDocumentPX.Style.Add("position", "absolute");
                            pnlDocumentPX.Style.Add("display", "flex");
                            pnlDocumentPX.Style.Add("transition", "1s");
                            pnlDocumentPX.Style.Add("left", "100%");
                            pnlDocumentPX.Style.Add("overflow", "hidden");
                            pnlDocumentPX.Style.Add("font-family", "'Computer'");

                            pnlProjetGauche = new Panel();
                            pnlProjetGauche.Width = Unit.Percentage(50);
                            pnlProjetGauche.Height = Unit.Percentage(100);
                            pnlProjetGauche.Style.Add("position", "relative");
                            pnlProjetGauche.Style.Add("display", "flex");

                            pnlProjetDroit = new Panel();
                            pnlProjetDroit.Width = Unit.Percentage(50);
                            pnlProjetDroit.Height = Unit.Percentage(100);
                            pnlProjetDroit.Style.Add("position", "relative");
                            pnlProjetDroit.Style.Add("display", "flex");

                            lbProjet1 = new Label();
                            lbProjet1.CssClass = "presentationProjet";
                            lbProjet1.Text = "Système de gestion de tickets";
                            lbProjet1.Style.Add("top", "7.4%");
                            lbProjet1.Style.Add("left", "10%");
                            lbProjet1.Style.Add("font-size", "32px");
                            lbProjet1.Style.Add("font-weight", "bold");
                            pnlProjetGauche.Controls.Add(lbProjet1);

                            Panel pnlCompetences = new Panel();
                            pnlCompetences.CssClass = "presentationProjet";
                            pnlCompetences.Style.Add("top", "7.4%");
                            pnlCompetences.Style.Add("left", "10%");
                            Label lbCompetences = new Label();
                            lbCompetences.CssClass = "sousTitre";
                            Label lbCompetence = new Label();
                            lbCompetence.Style.Add("font-size", "20px");
                            pnlProjetGauche.Controls.Add(lbProjet1);
                            Panel pnlImage = new Panel();
                            switch (k)
                            {
                                case 0:
                                    lbCompetences.Text = "Répondre aux incidents et aux demandes d’assistance et d’évolution :";
                                    lbCompetence.Text = "Collecter, suivre et orienter des demandes";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/Glpi/ticket.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "-webkit-fill-available");
                                    pnlImage.Style.Add("background-repeat", "no-repeat");
                                    pnlImage.Style.Add("background-size", "contain");
                                    pnlImage.Style.Add("top", "25%");
                                    pnlImage.Style.Add("left", "20%");
                                    pnlImage.Style.Add("position", "absolute");
                                    pnlDocumentPX.Controls.Add(pnlImage);
                                    break;
                                case 1:
                                    lbCompetences.Text = "Répondre aux incidents et aux demandes d’assistance et d’évolution :";
                                    lbCompetence.Text = "Traiter des demandes concernant les services réseau et système, applicatifs";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/Glpi/ticket2.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "-webkit-fill-available");
                                    pnlImage.Style.Add("background-repeat", "no-repeat");
                                    pnlImage.Style.Add("background-size", "contain");
                                    pnlImage.Style.Add("top", "25%");
                                    pnlImage.Style.Add("left", "20%");
                                    pnlImage.Style.Add("position", "absolute");
                                    pnlDocumentPX.Controls.Add(pnlImage);
                                    break;
                                case 2:
                                    lbCompetences.Text = "Répondre aux incidents et aux demandes d’assistance et d’évolution :";
                                    lbCompetence.Text = "Traiter des demandes concernant les services réseau et système, applicatifs";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/Glpi/ticket3.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "-webkit-fill-available");
                                    pnlImage.Style.Add("background-repeat", "no-repeat");
                                    pnlImage.Style.Add("background-size", "contain");
                                    pnlImage.Style.Add("top", "25%");
                                    pnlImage.Style.Add("left", "20%");
                                    pnlImage.Style.Add("position", "absolute");
                                    pnlDocumentPX.Controls.Add(pnlImage);
                                    break;

                            }
                            pnlProjetDroit.Controls.Add(pnlCompetences);
                            pnlDocumentPX.Style.Add("background-color", "white");

                            pnlDocumentPX.Controls.Add(pnlProjetGauche);
                            pnlDocumentPX.Controls.Add(pnlProjetDroit);
                            content.Controls.Add(pnlDocumentPX);
                        }
                        break;
                    case 5:
                        for (int k = 0; k < 1; k++)
                        {
                            pnlDocumentPX = new Panel();
                            pnlDocumentPX.ID = "pnlDocument" + k + "P" + i;
                            pnlDocumentPX.CssClass = "pnlDocumentsP" + i;
                            pnlDocumentPX.Width = Unit.Percentage(0);
                            pnlDocumentPX.Height = Unit.Percentage(100);
                            pnlDocumentPX.Style.Add("position", "absolute");
                            pnlDocumentPX.Style.Add("display", "flex");
                            pnlDocumentPX.Style.Add("transition", "1s");
                            pnlDocumentPX.Style.Add("left", "100%");
                            pnlDocumentPX.Style.Add("overflow", "hidden");
                            pnlDocumentPX.Style.Add("font-family", "'Computer'");

                            pnlProjetGauche = new Panel();
                            pnlProjetGauche.Width = Unit.Percentage(50);
                            pnlProjetGauche.Height = Unit.Percentage(100);
                            pnlProjetGauche.Style.Add("position", "relative");
                            pnlProjetGauche.Style.Add("display", "flex");

                            pnlProjetDroit = new Panel();
                            pnlProjetDroit.Width = Unit.Percentage(50);
                            pnlProjetDroit.Height = Unit.Percentage(100);
                            pnlProjetDroit.Style.Add("position", "relative");
                            pnlProjetDroit.Style.Add("display", "flex");

                            lbProjet1 = new Label();
                            lbProjet1.CssClass = "presentationProjet";
                            lbProjet1.Text = "Mon profil Linked'in";
                            lbProjet1.Style.Add("top", "7.4%");
                            lbProjet1.Style.Add("left", "10%");
                            lbProjet1.Style.Add("font-size", "32px");
                            lbProjet1.Style.Add("font-weight", "bold");
                            pnlProjetGauche.Controls.Add(lbProjet1);

                            Panel pnlCompetences = new Panel();
                            pnlCompetences.CssClass = "presentationProjet";
                            pnlCompetences.Style.Add("top", "7.4%");
                            pnlCompetences.Style.Add("left", "10%");
                            Label lbCompetences = new Label();
                            lbCompetences.CssClass = "sousTitre";
                            Label lbCompetence = new Label();
                            lbCompetence.Style.Add("font-size", "20px");
                            pnlProjetGauche.Controls.Add(lbProjet1);
                            switch (k)
                            {
                                case 0:
                                    lbCompetences.Text = "Organiser son développement professionnel :";
                                    lbCompetence.Text = "Mettre en œuvre des outils et stratégies de veille informationnelle";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    Panel pnlImage = new Panel();

                                    pnlImage = new Panel();
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "-webkit-fill-available");
                                    pnlImage.Style.Add("height", "80%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("left", "3%");
                                    pnlImage.BackImageUrl = "/Images/linkedin/profil2.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);

                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/linkedin/profil1.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "100%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("left", "3%");
                                    pnlProjetDroit.Controls.Add(pnlImage);
                                    break;

                            }
                            pnlProjetDroit.Controls.Add(pnlCompetences);
                            pnlDocumentPX.Style.Add("background-color", "white");

                            pnlDocumentPX.Controls.Add(pnlProjetGauche);
                            pnlDocumentPX.Controls.Add(pnlProjetDroit);
                            content.Controls.Add(pnlDocumentPX);
                        }
                        break;
                    case 6:
                        for (int k = 0; k < 2; k++)
                        {
                            pnlDocumentPX = new Panel();
                            pnlDocumentPX.ID = "pnlDocument" + k + "P" + i;
                            pnlDocumentPX.CssClass = "pnlDocumentsP" + i;
                            pnlDocumentPX.Width = Unit.Percentage(0);
                            pnlDocumentPX.Height = Unit.Percentage(100);
                            pnlDocumentPX.Style.Add("position", "absolute");
                            pnlDocumentPX.Style.Add("display", "flex");
                            pnlDocumentPX.Style.Add("transition", "1s");
                            pnlDocumentPX.Style.Add("left", "100%");
                            pnlDocumentPX.Style.Add("overflow", "hidden");
                            pnlDocumentPX.Style.Add("font-family", "'Computer'");

                            pnlProjetGauche = new Panel();
                            pnlProjetGauche.Width = Unit.Percentage(50);
                            pnlProjetGauche.Height = Unit.Percentage(100);
                            pnlProjetGauche.Style.Add("position", "relative");
                            pnlProjetGauche.Style.Add("display", "flex");

                            pnlProjetDroit = new Panel();
                            pnlProjetDroit.Width = Unit.Percentage(50);
                            pnlProjetDroit.Height = Unit.Percentage(100);
                            pnlProjetDroit.Style.Add("position", "relative");
                            pnlProjetDroit.Style.Add("display", "flex");

                            lbProjet1 = new Label();
                            lbProjet1.CssClass = "presentationProjet";
                            lbProjet1.Text = "Audit de conformité aux réglementations de la RGPD";
                            lbProjet1.Style.Add("top", "7.4%");
                            lbProjet1.Style.Add("left", "10%");
                            lbProjet1.Style.Add("font-size", "32px");
                            lbProjet1.Style.Add("font-weight", "bold");
                            pnlProjetGauche.Controls.Add(lbProjet1);

                            Panel pnlCompetences = new Panel();
                            pnlCompetences.CssClass = "presentationProjet";
                            pnlCompetences.Style.Add("top", "7.4%");
                            pnlCompetences.Style.Add("left", "10%");
                            Label lbCompetences = new Label();
                            lbCompetences.CssClass = "sousTitre";
                            Label lbCompetence = new Label();
                            lbCompetence.Style.Add("font-size", "20px");
                            pnlProjetGauche.Controls.Add(lbProjet1);
                            switch (k)
                            {
                                case 0:
                                    lbCompetences.Text = "Développer la présence en ligne de l’organisation :";
                                    //lbCompetence.Text = "Recenser et identifier les ressources numériques";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    //pnlCompetences.Controls.Add(lbCompetence);

                                    Panel pnlImage = new Panel();

                                    pnlImage = new Panel();
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "-webkit-fill-available");
                                    pnlImage.Style.Add("height", "80%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("left", "5%");
                                    pnlImage.BackImageUrl = "/Images/auditRGPD/analyseConformite.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);

                                    pnlImage = new Panel();
                                    pnlImage.BackImageUrl = "/Images/auditRGPD/preuveMentions.png";
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "100%");
                                    pnlImage.Style.Add("height", "100%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlProjetDroit.Controls.Add(pnlImage);
                                    break;
                                case 1:
                                    lbCompetences.Text = "Développer la présence en ligne de l’organisation :";
                                    //lbCompetence.Text = "Recenser et identifier les ressources numériques";
                                    pnlCompetences.Controls.Add(lbCompetences);
                                    //pnlCompetences.Controls.Add(lbCompetence);

                                    pnlImage = new Panel();
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "-webkit-fill-available");
                                    pnlImage.Style.Add("height", "80%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("left", "10%");
                                    pnlImage.BackImageUrl = "/Images/auditRGPD/PropositionDeMentionsLegales.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);

                                    break;

                            }
                            pnlProjetDroit.Controls.Add(pnlCompetences);
                            pnlDocumentPX.Style.Add("background-color", "white");

                            pnlDocumentPX.Controls.Add(pnlProjetGauche);
                            pnlDocumentPX.Controls.Add(pnlProjetDroit);
                            content.Controls.Add(pnlDocumentPX);
                        }
                        break;
                    case 7:
                        for (int k = 0; k < 1; k++)
                        {
                            pnlDocumentPX = new Panel();
                            pnlDocumentPX.ID = "pnlDocument" + k + "P" + i;
                            pnlDocumentPX.CssClass = "pnlDocumentsP" + i;
                            pnlDocumentPX.Width = Unit.Percentage(0);
                            pnlDocumentPX.Height = Unit.Percentage(100);
                            pnlDocumentPX.Style.Add("position", "absolute");
                            pnlDocumentPX.Style.Add("display", "flex");
                            pnlDocumentPX.Style.Add("transition", "1s");
                            pnlDocumentPX.Style.Add("left", "100%");
                            pnlDocumentPX.Style.Add("overflow", "hidden");
                            pnlDocumentPX.Style.Add("font-family", "'Computer'");

                            pnlProjetGauche = new Panel();
                            pnlProjetGauche.Width = Unit.Percentage(50);
                            pnlProjetGauche.Height = Unit.Percentage(100);
                            pnlProjetGauche.Style.Add("position", "relative");
                            pnlProjetGauche.Style.Add("display", "flex");

                            pnlProjetDroit = new Panel();
                            pnlProjetDroit.Width = Unit.Percentage(50);
                            pnlProjetDroit.Height = Unit.Percentage(100);
                            pnlProjetDroit.Style.Add("position", "relative");
                            pnlProjetDroit.Style.Add("display", "flex");

                            lbProjet1 = new Label();
                            lbProjet1.CssClass = "presentationProjet";
                            lbProjet1.Text = "IA pour répondre aux demandes clients par téléphone";
                            lbProjet1.Style.Add("top", "7.4%");
                            lbProjet1.Style.Add("left", "10%");
                            lbProjet1.Style.Add("font-size", "32px");
                            lbProjet1.Style.Add("font-weight", "bold");
                            pnlProjetGauche.Controls.Add(lbProjet1);

                            Panel pnlCompetences = new Panel();
                            pnlCompetences.CssClass = "presentationProjet";
                            pnlCompetences.Style.Add("top", "7.4%");
                            pnlCompetences.Style.Add("left", "10%");
                            Label lbCompetences = new Label();
                            lbCompetences.CssClass = "sousTitre";
                            Label lbCompetence = new Label();
                            lbCompetence.Style.Add("font-size", "20px");
                            pnlProjetGauche.Controls.Add(lbProjet1);
                            switch (k)
                            {
                                case 0:
                                    lbCompetences.Text = "Travailler en mode projet :";
                                    lbCompetence.Text = "Évaluer les indicateurs de suivi d’un projet et analyser les écarts";
                                    pnlCompetences.Controls.Add(lbCompetence);

                                    Panel pnlImage = new Panel();

                                    pnlImage = new Panel();
                                    pnlImage.CssClass = "imageProjet";
                                    pnlImage.Style.Add("width", "-webkit-fill-available%");
                                    pnlImage.Style.Add("height", "80%");
                                    pnlImage.Style.Add("top", "20%");
                                    pnlImage.Style.Add("left", "10%");
                                    pnlImage.BackImageUrl = "/Images/IA/ecarts.png";
                                    pnlProjetGauche.Controls.Add(pnlImage);

                                    break;

                            }
                            pnlProjetDroit.Controls.Add(pnlCompetences);
                            pnlDocumentPX.Style.Add("background-color", "white");

                            pnlDocumentPX.Controls.Add(pnlProjetGauche);
                            pnlDocumentPX.Controls.Add(pnlProjetDroit);
                            content.Controls.Add(pnlDocumentPX);
                        }
                        break;
                    default:

                        break;

                }

                switch (i)
                {
                    case 0:
                        pnlProjet1.Style.Add("background-image", "url(/Images/screen_tableau.png)");
                        break;
                    case 1:
                        pnlProjet1.Style.Add("background-image", "url(/Images/Recensement/recensement2.png)");
                        break;
                    case 2:
                        pnlProjet1.Style.Add("background-color", "white");
                        break;
                    case 3:
                        pnlProjet1.Style.Add("background-image", "url(/Images/AP3/objectif.png)");
                        break;
                    case 4:
                        pnlProjet1.Style.Add("background-image", "url(/Images/Glpi/ticket.png)");
                        break;
                    case 5:
                        pnlProjet1.Style.Add("background-color", "white");
                        break;
                    case 6:
                        pnlProjet1.Style.Add("background-color", "white");
                        break;
                    case 7:
                        pnlProjet1.Style.Add("background-image", "url(/Images/IA/interfaceIA.png)");
                        break;

                }

                pnlProjet1.Style.Add("font-family", "'Computer'");

                pnlProjetGauche = new Panel();
                pnlProjetGauche.Width = Unit.Percentage(50);
                pnlProjetGauche.Height = Unit.Percentage(100);
                pnlProjetGauche.Style.Add("position", "relative");
                pnlProjetGauche.Style.Add("display", "flex");

                pnlProjetDroit = new Panel();
                pnlProjetDroit.Width = Unit.Percentage(50);
                pnlProjetDroit.Height = Unit.Percentage(100);
                pnlProjetDroit.Style.Add("position", "relative");
                pnlProjetDroit.Style.Add("display", "flex");

                lbProjet1 = new Label();
                lbProjet1.CssClass = "presentationProjet";
                switch (i)
                {
                    case 0:
                        lbProjet1.Text = "Outil de gestion pour des écrans";
                        break;
                    case 1:
                        lbProjet1.Text = "Sous-partie outil de gestion";
                        break;
                    case 2:
                        lbProjet1.Text = "Outil de gestion QRCode";
                        break;
                    case 3:
                        lbProjet1.Text = "Espace de rencontre entre créateurs de contenu et entreprises";
                        break;
                    case 4:
                        lbProjet1.Text = "Système de gestion de tickets";
                        break;
                    case 5:
                        lbProjet1.Text = "Mon profil Linked'in";
                        break;
                    case 6:
                        lbProjet1.Text = "Audit de conformité aux réglementations de la RGPD";
                        break;
                    case 7:
                        lbProjet1.Text = "IA pour répondre aux demandes clients par téléphone";
                        break;


                }
                lbProjet1.Style.Add("top", "7.4%");
                lbProjet1.Style.Add("left", "10%");
                lbProjet1.Style.Add("font-size", "32px");
                lbProjet1.Style.Add("font-weight", "bold");
                pnlProjetGauche.Controls.Add(lbProjet1);


                pnlDescDemande = new Panel();
                pnlDescDemande.CssClass = "presentationProjet";
                pnlDescDemande.Style.Add("top", "26%");
                pnlDescDemande.Style.Add("left", "10%");

                lbTitreDescDemande = new Label();
                lbTitreDescDemande.CssClass = "sousTitre";
                lbTitreDescDemande.Text = "Description de la demande :";
                pnlDescDemande.Controls.Add(lbTitreDescDemande);

                lbDescDemande = new Label();
                lbDescDemande.Style.Add("font-size", "20px");
                lbDescDemande.Style.Add("text-align", "justify");
                pnlDescDemande.Controls.Add(lbDescDemande);

                pnlProjetGauche.Controls.Add(pnlDescDemande);

                pnlInfos = new Panel();
                pnlInfos.CssClass = "presentationProjet";
                pnlInfos.Style.Add("top", "63%");
                pnlInfos.Style.Add("left", "10%");

                lbTitreInfos = new Label();
                lbTitreInfos.CssClass = "sousTitre";
                lbTitreInfos.Text = "Infos complémentaires :";
                pnlInfos.Controls.Add(lbTitreInfos);

                lbInfos = new Label();
                lbInfos.Style.Add("font-size", "20px");
                lbInfos.Style.Add("text-align", "justify");
                pnlInfos.Controls.Add(lbInfos);

                switch (i)
                {
                    case 0:
                        lbDescDemande.Text = "Création d'un outil permettant la gestion efficace de tous les écrans de présentation de l'entreprise pour minimiser le temps de gestion nécessaire à leur fonctionnement.";
                        lbInfos.Text = "Pas de contraintes pour le choix de l'outil. <br/> Nous devons pouvoir voir l'état de la globalité des écrans et leur emplacement dans l'entreprise. <br/> L'outil doit être disponible sur le site web de l'entrprise pour être utilisable par plusieurs personnes";
                        break;
                    case 1:
                        lbDescDemande.Text = "Inventaire des ressoucres informatiques possédées et mise à jour de le nombre selon les besoins";
                        lbInfos.Text = "Analyse des outils à disposition pour trouver le meilleur outil compatible";
                        break;
                    case 2:
                        lbDescDemande.Text = "Créer une page qui puisse regrouper tous les pocessus qui arrivaient par un scan de QR-Code";
                        lbInfos.Text = "Améliorer le style et faire que ce soit visualisable sur téléphone.";
                        HyperLink hlFigma = new HyperLink();
                        hlFigma.NavigateUrl = "https://www.figma.com/board/gWfuepOgt9UT3YlmyvEOtG/Processus-Page-DDEDevisGlobal?node-id=1-24&node-type=rounded_rectangle&t=i7iFeRVpg7HnwskF-0";
                        hlFigma.Target = "_blank";
                        hlFigma.Text = "Processus des étapes de fonctionnement utilisateur illustré de l'application";
                        pnlInfos.Controls.Add(hlFigma);
                        break;
                    case 3:
                        lbDescDemande.Text = "Mise en place d'un système permettant de faciliter la rencontre entre les entreprises souhaitant proposer des placement de produit pour gagner en visibililté avec des créateurs de contenu pouvant leur offrir celle-ci.";
                        lbInfos.Text = "Création d'une page web associé à une application mobile pour la communication.";
                        break;
                    case 4:
                        lbDescDemande.Text = "Simulation à travers une machine virtuelle d'un système de ticketing";
                        lbInfos.Text = "mise en place de la VM et de GLPI (gestionnaire libre du parc informatique)";
                        break;
                    case 5:
                        lbDescDemande.Text = "Mise en place de mon profil linked'in pour mon projet professionnel";
                        lbInfos.Text = "Permettre la visibilité de mon profils aux entreprises souhaitant me recruter pour trouver une alternance.";
                        break;
                    case 6:
                        lbDescDemande.Text = "Mise en conformité au RGPD du site internet d'une librairie en ligne fictive.";
                        lbInfos.Text = "Recenser les traitements sur les données à caractère personnel au sein de l’organisation.";
                        break;
                    case 7:
                        lbDescDemande.Text = "Mise en place d'un système permettant le chat audio et écrit à une IA lié à l'entreprise.";
                        lbInfos.Text = "Chat audio via téléphone pour répondre aux demandes fréquentes des clients sans occuper les employés.";
                        break;
                    default:
                        lbDescDemande.Text = "lorem";
                        lbInfos.Text = "lorem";
                        break;
                }
                pnlProjetGauche.Controls.Add(pnlInfos);
                pnlProjet1.Controls.Add(pnlProjetGauche);

                pnlProjetDroit.Style.Add("justify-content", "center");
                pnlProjetDroit.Style.Add("align-items", "center");

                pnlProjetsOutils = new Panel();
                pnlProjetsOutils.CssClass = "presentationProjet";
                pnlProjetsOutils.Style.Add("max-width", "70%");
                pnlProjetsOutils.Style.Add("padding-left", "2rem");

                lbProjetTitreOutils = new Label();
                lbProjetTitreOutils.CssClass = "sousTitre";
                lbProjetTitreOutils.Text = "Outils utilisés :";
                pnlProjetsOutils.Controls.Add(lbProjetTitreOutils);

                List<string> outils = new List<string>();
                int j = 0;
                switch (i)
                {
                    case 0:
                        outils = new List<string> { "SQL Express", "SQL Server Management", "Visual Studio", "IIS Express", "SweetHome3d", "Windows Forms", "C#", "ASP.NET", "Javascript", "CSS", "AJAX / JQuery", "Teams" };
                        foreach (string outil in outils)
                        {
                            j++;
                            lbProjetOutils = new Label() { Text = "\u3009" + outil };
                            lbProjetOutils.ID = "lbProjetOutils" + j;
                            lbProjetOutils.Style.Add("padding", "1rem 3.5rem");
                            lbProjetOutils.Style.Add("font-size", "20px");
                            lbProjetOutils.Style.Add("position", "relative");
                            lbProjetOutils.Style.Add("background-repeat", "no-repeat");
                            lbProjetOutils.Style.Add("background-position", "left center");
                            lbProjetOutils.Style.Add("background-size", "40px");

                            pnlProjetsOutils.Controls.Add(lbProjetOutils);
                            switch (j)
                            {
                                case 1:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/sql_server.png)");
                                    break;
                                case 2:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/SSMS_v2.png)");
                                    break;
                                case 3:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/Visual_Studio_Icon.png)");
                                    break;
                                case 4:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/Microsoft-IIS-1024x787.png)");
                                    break;
                                case 5:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/SweetHome3D.png)");
                                    break;
                                case 6:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/WinForms_v2.png)");
                                    break;
                                case 7:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/c_sharp_icon.png)");
                                    break;
                                case 8:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/NET_Core_Logo_v2.png)");
                                    break;
                                case 9:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/js_icon.png)");
                                    break;
                                case 10:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/css.png)");
                                    break;
                                case 11:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/ajax_jquery.png)");
                                    break;
                                case 12:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/icon_teams.png)");
                                    break;
                            }
                        }
                        break;
                    case 1:
                        outils = new List<string> { "GoogleSheets", "Skype", "LibreOfficeWriter" };
                        foreach (string outil in outils)
                        {
                            j++;
                            lbProjetOutils = new Label() { Text = "\u3009" + outil };
                            lbProjetOutils.ID = "lbProjetOutils" + j;
                            lbProjetOutils.Style.Add("padding", "1rem 3.5rem");
                            lbProjetOutils.Style.Add("font-size", "20px");
                            lbProjetOutils.Style.Add("position", "relative");
                            lbProjetOutils.Style.Add("background-repeat", "no-repeat");
                            lbProjetOutils.Style.Add("background-position", "left center");
                            lbProjetOutils.Style.Add("background-size", "40px");

                            pnlProjetsOutils.Controls.Add(lbProjetOutils);
                            switch (j)
                            {
                                case 1:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/img.png)");
                                    break;
                                case 2:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/img.png)");
                                    break;
                                case 3:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/img.png)");
                                    break;
                                    //case 4:
                                    //  lbProjetOutils.Style.Add("background-image", "url(Images/vercel_icon.png)");
                                    //  break;
                                    //case 5:
                                    //  lbProjetOutils.Style.Add("background-image", "url(Images/github_icon.png)");
                                    //  break;
                            }
                        }
                        break;
                    case 2:
                        outils = new List<string> { "SQL Express", "SQL Server Management", "Visual Studio", "IIS Express", "C#", "ASP.NET", "Javascript", "CSS", "AJAX / JQuery", "Figma" };
                        foreach (string outil in outils)
                        {
                            j++;
                            lbProjetOutils = new Label() { Text = "\u3009" + outil };
                            lbProjetOutils.ID = "lbProjetOutils" + j;
                            lbProjetOutils.Style.Add("padding", "1rem 3.5rem");
                            lbProjetOutils.Style.Add("font-size", "20px");
                            lbProjetOutils.Style.Add("position", "relative");
                            lbProjetOutils.Style.Add("background-repeat", "no-repeat");
                            lbProjetOutils.Style.Add("background-position", "left center");
                            lbProjetOutils.Style.Add("background-size", "40px");

                            pnlProjetsOutils.Controls.Add(lbProjetOutils);
                            switch (j)
                            {
                                case 1:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/sql_server.png)");
                                    break;
                                case 2:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/SSMS_v2.png)");
                                    break;
                                case 3:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/Visual_Studio_Icon.png)");
                                    break;
                                case 4:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/Microsoft-IIS-1024x787.png)");
                                    break;
                                case 5:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/c_sharp_icon.png)");
                                    break;
                                case 6:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/NET_Core_Logo_v2.png)");
                                    break;
                                case 7:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/js_icon.png)");
                                    break;
                                case 8:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/css.png)");
                                    break;
                                case 9:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/ajax_jquery.png)");
                                    break;
                                case 10:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/figma_icon.png)");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        outils = new List<string> { "VisualStudioCode", "JS", "CSS", "Teams", "GitHub", "HTML", "Xampp" };
                        foreach (string outil in outils)
                        {
                            j++;
                            lbProjetOutils = new Label() { Text = "\u3009" + outil };
                            lbProjetOutils.ID = "lbProjetOutils" + j;
                            lbProjetOutils.Style.Add("padding", "1rem 3.5rem");
                            lbProjetOutils.Style.Add("font-size", "20px");
                            lbProjetOutils.Style.Add("position", "relative");
                            lbProjetOutils.Style.Add("background-repeat", "no-repeat");
                            lbProjetOutils.Style.Add("background-position", "left center");
                            lbProjetOutils.Style.Add("background-size", "40px");

                            pnlProjetsOutils.Controls.Add(lbProjetOutils);
                            switch (j)
                            {
                                case 1:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/Visual_Studio_Icon.png)");
                                    break;
                                case 2:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/js_icon.png)");
                                    break;
                                case 3:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/css.png)");
                                    break;
                                case 4:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/icon_teams.png)");
                                    break;
                                case 5:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/GitHub_icon.png)");
                                    break;
                                case 6:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/html_icon.png)");
                                    break;
                                case 7:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/xampp_icon.png)");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        outils = new List<string> { "GLPI" };
                        foreach (string outil in outils)
                        {
                            j++;
                            lbProjetOutils = new Label() { Text = "\u3009" + outil };
                            lbProjetOutils.ID = "lbProjetOutils" + j;
                            lbProjetOutils.Style.Add("padding", "1rem 3.5rem");
                            lbProjetOutils.Style.Add("font-size", "20px");
                            lbProjetOutils.Style.Add("position", "relative");
                            lbProjetOutils.Style.Add("background-repeat", "no-repeat");
                            lbProjetOutils.Style.Add("background-position", "left center");
                            lbProjetOutils.Style.Add("background-size", "40px");

                            pnlProjetsOutils.Controls.Add(lbProjetOutils);
                            switch (j)
                            {
                                case 1:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/img.png)");
                                    break;
                            }
                        }
                        break;
                    case 5:
                        outils = new List<string> { "Linked'in" };
                        foreach (string outil in outils)
                        {
                            j++;
                            lbProjetOutils = new Label() { Text = "\u3009" + outil };
                            lbProjetOutils.ID = "lbProjetOutils" + j;
                            lbProjetOutils.Style.Add("padding", "1rem 3.5rem");
                            lbProjetOutils.Style.Add("font-size", "20px");
                            lbProjetOutils.Style.Add("position", "relative");
                            lbProjetOutils.Style.Add("background-repeat", "no-repeat");
                            lbProjetOutils.Style.Add("background-position", "left center");
                            lbProjetOutils.Style.Add("background-size", "40px");

                            pnlProjetsOutils.Controls.Add(lbProjetOutils);
                            switch (j)
                            {
                                case 1:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/linkedin_icon.png)");
                                    break;
                            }
                        }
                        break;
                    case 6:
                        outils = new List<string> { "Google" };
                        foreach (string outil in outils)
                        {
                            j++;
                            lbProjetOutils = new Label() { Text = "\u3009" + outil };
                            lbProjetOutils.ID = "lbProjetOutils" + j;
                            lbProjetOutils.Style.Add("padding", "1rem 3.5rem");
                            lbProjetOutils.Style.Add("font-size", "20px");
                            lbProjetOutils.Style.Add("position", "relative");
                            lbProjetOutils.Style.Add("background-repeat", "no-repeat");
                            lbProjetOutils.Style.Add("background-position", "left center");
                            lbProjetOutils.Style.Add("background-size", "40px");

                            pnlProjetsOutils.Controls.Add(lbProjetOutils);
                            switch (j)
                            {
                                case 1:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/img.png)");
                                    break;
                            }
                        }
                        break;
                    case 7:
                        outils = new List<string> { "SQL Express", "SQL Server Management", "Visual Studio", "IIS Express", "C#", "ASP.NET", "Javascript", "CSS", "AJAX / JQuery", "OpenAI", "Postman" };

                        foreach (string outil in outils)
                        {
                            j++;
                            lbProjetOutils = new Label() { Text = "\u3009" + outil };
                            lbProjetOutils.ID = "lbProjetOutils" + j;
                            lbProjetOutils.Style.Add("padding", "1rem 3.5rem");
                            lbProjetOutils.Style.Add("font-size", "20px");
                            lbProjetOutils.Style.Add("position", "relative");
                            lbProjetOutils.Style.Add("background-repeat", "no-repeat");
                            lbProjetOutils.Style.Add("background-position", "left center");
                            lbProjetOutils.Style.Add("background-size", "40px");

                            pnlProjetsOutils.Controls.Add(lbProjetOutils);
                            switch (j)
                            {
                                case 1:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/sql_server.png)");
                                    break;
                                case 2:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/SSMS_v2.png)");
                                    break;
                                case 3:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/Visual_Studio_Icon.png)");
                                    break;
                                case 4:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/Microsoft-IIS-1024x787.png)");
                                    break;
                                case 5:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/c_sharp_icon.png)");
                                    break;
                                case 6:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/NET_Core_Logo_v2.png)");
                                    break;
                                case 7:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/js_icon.png)");
                                    break;
                                case 8:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/css.png)");
                                    break;
                                case 9:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/ajax_jquery.png)");
                                    break;
                                case 10:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/openai_icon.png)");
                                    break;
                                case 11:
                                    lbProjetOutils.Style.Add("background-image", "url(Images/postman_icon.png)");
                                    break;
                            }
                        }
                        break;

                }


                pnlProjetDroit.Controls.Add(pnlProjetsOutils);
                pnlProjet1.Controls.Add(pnlProjetDroit);
                content.Controls.Add(pnlProjet1);

                if (!string.IsNullOrEmpty(Request.Params["projetid"]))
                {
                    int param = Convert.ToInt32(Request.Params["projetid"]);
                    if (param == i)
                    {
                        pnlProjet1.Style.Add("visibility", "visible");
                        pnlProjet1.Style.Add("transform", "scale(1)");
                        pnlProjet1.Style.Add("opacity", "1");
                        pnlProjet1.Style.Add("top", "0");
                        hlPrecedent.Style.Add("display", "block");
                        hlNext.Style.Add("display", "block");
                        hlNext.NavigateUrl = "javascript:Next(" + i + ");";
                        hlPrecedent.NavigateUrl = "javascript:Precedent(" + i + ");";
                    }
                }
            }

            content.Controls.Add(hlPrecedent);
            content.Controls.Add(hlNext);
            #endregion

            #region Outils et Langages
            Panel pnlCode = new Panel();
            pnlCode.ID = "pnlVisualStudio";
            pnlCode.CssClass = "";
            pnlCode.Width = Unit.Percentage(100);
            pnlCode.Height = Unit.Percentage(100);
            pnlCode.Style.Add("display", "grid");
            pnlCode.Style.Add("grid", "repeat(25,auto)/repeat(40,auto)");
            pnlCode.Style.Add("position", "absolute");
            pnlCode.Style.Add("background-image", "url(/Images/purple_code_matrix.jpg)");
            pnlCode.Style.Add("visibility", "hidden");
            pnlCode.Style.Add("background-size", "contain");
            pnlCode.Style.Add("z-index", "5");
            content.Controls.Add(pnlCode);
            Panel pnlblack = new Panel();
            for (i = 0; i < 1000; i++)
            {
                pnlblack = new Panel();
                pnlblack.ID = "pnlblack" + i;
                pnlblack.CssClass = "pnlblack";
                pnlblack.Style.Add("background-color", "black");
                pnlCode.Controls.Add(pnlblack);
            }
            Panel cmd = new Panel();
            for (i = 0; i < 20; i++)
            {
                cmd = new Panel();
                cmd.BackImageUrl = "/Images/cmd.png";
                cmd.ID = "cmd" + i;
                cmd.CssClass = "cmd";
                cmd.Height = Unit.Percentage(50);
                cmd.Width = Unit.Percentage(50);
                cmd.Style.Add("position", "absolute");
                cmd.Style.Add("background-repeat", "no-repeat");
                cmd.Style.Add("background-size", "contain");
                cmd.Style.Add("visibility", "hidden");
                cmd.Style.Add("transform", "scale(0.1)");
                cmd.Style.Add("transition", "0.25s");
                switch (i)
                {
                    case 0:
                        cmd.Style.Add("top", "7%");
                        cmd.Style.Add("left", "5%");
                        break;
                    case 1:
                        cmd.Style.Add("top", "10%");
                        cmd.Style.Add("left", "7%");
                        break;
                    case 2:
                        cmd.Style.Add("top", "13%");
                        cmd.Style.Add("left", "9%");
                        break;
                    case 3:
                        cmd.Style.Add("top", "16%");
                        cmd.Style.Add("left", "11%");
                        break;
                    case 4:
                        cmd.Style.Add("top", "5%");
                        cmd.Style.Add("left", "40%");
                        break;
                    case 5:
                        cmd.Style.Add("top", "8%");
                        cmd.Style.Add("left", "42%");
                        break;
                    case 6:
                        cmd.Style.Add("top", "11%");
                        cmd.Style.Add("left", "44%");
                        break;
                    case 7:
                        cmd.Style.Add("top", "14%");
                        cmd.Style.Add("left", "46%");
                        break;
                    case 8:
                        cmd.Style.Add("top", "17%");
                        cmd.Style.Add("left", "48%");
                        break;
                    case 9:
                        cmd.Style.Add("top", "20%");
                        cmd.Style.Add("left", "50%");
                        break;
                    case 10:
                        cmd.Style.Add("top", "40%");
                        cmd.Style.Add("left", "1%");
                        break;
                    case 11:
                        cmd.Style.Add("top", "43%");
                        cmd.Style.Add("left", "3%");
                        break;
                    case 12:
                        cmd.Style.Add("top", "46%");
                        cmd.Style.Add("left", "5%");
                        break;
                    case 13:
                        cmd.Style.Add("top", "49%");
                        cmd.Style.Add("left", "7%");
                        break;
                    case 14:
                        cmd.Style.Add("top", "35%");
                        cmd.Style.Add("left", "36%");
                        break;
                    case 15:
                        cmd.Style.Add("top", "38%");
                        cmd.Style.Add("left", "38%");
                        break;
                    case 16:
                        cmd.Style.Add("top", "41%");
                        cmd.Style.Add("left", "40%");
                        break;
                    case 17:
                        cmd.Style.Add("top", "44%");
                        cmd.Style.Add("left", "42%");
                        break;
                    case 18:
                        cmd.Style.Add("top", "47%");
                        cmd.Style.Add("left", "44%");
                        break;
                    case 19:
                        cmd.Style.Add("top", "50%");
                        cmd.Style.Add("left", "46%");
                        break;
                }
                content.Controls.Add(cmd);
            }
            Panel blueScreen = new Panel();
            blueScreen.ID = "blueScreen";
            blueScreen.Style.Add("background-image", "url(/Images/blue-screen-of-death-in-windows-10.jpg)");
            blueScreen.Style.Add("display", "none");
            blueScreen.Style.Add("z-index", "100");
            blueScreen.Style.Add("position", "absolute");
            blueScreen.Style.Add("grid-row-start", "1");
            blueScreen.Style.Add("grid-row-end", "3");
            blueScreen.Width = Unit.Percentage(100);
            blueScreen.Height = Unit.Percentage(100);
            main.Controls.Add(blueScreen);
            #endregion

            #region Veille
            Panel pnlVeillePompier = new Panel();
            pnlVeillePompier.ID = "pnlVeillePompier0";
            pnlVeillePompier.CssClass = "pnlVeilles";
            pnlVeillePompier.Width = Unit.Percentage(100);
            pnlVeillePompier.Height = Unit.Percentage(100);
            pnlVeillePompier.Style.Add("visibility", "hidden");
            pnlVeillePompier.Style.Add("display", "flex");
            pnlVeillePompier.Style.Add("position", "absolute");
            pnlVeillePompier.Style.Add("transform", "scale(0.05)");
            pnlVeillePompier.Style.Add("opacity", "0");
            pnlVeillePompier.Style.Add("top", "50%");
            pnlVeillePompier.Style.Add("transition", "0.5s");
            pnlVeillePompier.BackImageUrl = "/Images/veille/accueil.png";

            for (int k = 0; k < 2; k++)
            {
                pnlDocumentPX = new Panel();
                pnlDocumentPX.ID = "pnlVeille" + k + "P0";
                pnlDocumentPX.CssClass = "pnlDocVeilles";
                pnlDocumentPX.Width = Unit.Percentage(0);
                pnlDocumentPX.Height = Unit.Percentage(100);
                pnlDocumentPX.Style.Add("position", "absolute");
                pnlDocumentPX.Style.Add("display", "flex");
                pnlDocumentPX.Style.Add("transition", "1s");
                pnlDocumentPX.Style.Add("left", "100%");
                pnlDocumentPX.Style.Add("overflow", "hidden");
                pnlDocumentPX.Style.Add("font-family", "'Computer'");

                pnlProjetGauche = new Panel();
                pnlProjetGauche.Width = Unit.Percentage(100);
                pnlProjetGauche.Height = Unit.Percentage(100);
                pnlProjetGauche.Style.Add("position", "relative");
                pnlProjetGauche.Style.Add("display", "flex");

                pnlProjetDroit = new Panel();
                pnlProjetDroit.Width = Unit.Percentage(100);
                pnlProjetDroit.Height = Unit.Percentage(100);
                pnlProjetDroit.Style.Add("position", "relative");
                pnlProjetDroit.Style.Add("display", "flex");
                switch (k)
                {
                    case 0:
                        pnlDocumentPX.BackImageUrl = "/Images/veille/Mails.png";
                        Panel pnlImage = new Panel();
                        pnlImage.CssClass = "imageProjet";
                        pnlImage.Style.Add("width", "70%");
                        pnlImage.Style.Add("height", "-webkit-fill-available");
                        pnlImage.Style.Add("top", "20%");
                        pnlImage.Style.Add("left", "20%");
                        pnlImage.BackImageUrl = "/Images/veille/alertes.png";
                        pnlProjetDroit.Controls.Add(pnlImage);
                        break;
                    case 1:
                        pnlDocumentPX.BackImageUrl = "mailInformatique";
                        pnlDocumentPX.BackColor = Color.White;
                        pnlImage = new Panel();
                        pnlImage.CssClass = "imageProjet";
                        pnlImage.Style.Add("width", "150%");
                        pnlImage.Style.Add("height", "150%");
                        pnlImage.Style.Add("top", "20%");
                        pnlImage.Style.Add("left", "20%");
                        pnlImage.BackImageUrl = "/Images/veille/mailInformatique.png";
                        pnlProjetGauche.Controls.Add(pnlImage);
                        break;
                }
                pnlDocumentPX.Controls.Add(pnlProjetGauche);
                pnlDocumentPX.Controls.Add(pnlProjetDroit);
                content.Controls.Add(pnlDocumentPX);
            }
            content.Controls.Add(pnlVeillePompier);
            #endregion

            #endregion


            #region Footer

            #region Applications
            Panel pnlApplications = new Panel();
            pnlApplications.Style.Add("grid-column-start", "2");
            pnlApplications.Style.Add("display", "grid");
            pnlApplications.Style.Add("grid-template-columns", "repeat(5,auto)");
            pnlApplications.Style.Add("justify-content", "center");
            pnlApplications.Style.Add("align-items", "center");
            pnlApplications.Style.Add("column-gap", "3%");

            #region Windows
            HyperLink hlAppli = new HyperLink();
            hlAppli.ID = "Windows";
            hlAppli.CssClass = "applis";
            hlAppli.NavigateUrl = "javascript:openMenu('Windows');";
            hlAppli.ImageUrl = "~/Images/windows11_32px.png";
            hlAppli.Attributes.Add("onmouseover", "tooltipOn('Windows')");
            hlAppli.Attributes.Add("onmouseout", "tooltipOut('Windows')");
            pnlApplications.Controls.Add(hlAppli);

            Label tooltip = new Label();
            tooltip.CssClass = "tooltip";
            tooltip.ID = "WindowsTooltip";
            tooltip.Text = "Démarrer";
            tooltip.Style.Add("top", "91%");
            tooltip.Style.Add("left", "44%");
            main.Controls.Add(tooltip);

            Panel pnlWindows = new Panel();
            pnlWindows.ID = "pnlWindows";
            pnlWindows.Style.Add("position", "absolute");
            pnlWindows.Style.Add("padding", "10px");
            pnlWindows.Style.Add("left", "44%");
            pnlWindows.Style.Add("top", "96.5%");
            pnlWindows.Style.Add("transition", "0.3s");
            pnlWindows.Style.Add("transform", "scale(0.5)");
            pnlWindows.Style.Add("z-index", "-1");
            pnlWindows.Style.Add("border-radius", "10px");
            pnlWindows.Style.Add("background-color", "#f0f0f0");

            HyperLink hlarreter = new HyperLink();
            hlarreter.ID = "hlarreter";
            hlarreter.NavigateUrl = "javascript:arret();";
            hlarreter.Text = "Arrêter";
            hlarreter.Style.Add("text-decoration", "none");
            hlarreter.Style.Add("font-family", "'Segoe UI Variable Text'");
            hlarreter.Style.Add("font-size", "16px");
            hlarreter.Style.Add("color", "black");
            pnlWindows.Controls.Add(hlarreter);
            main.Controls.Add(pnlWindows);
            #endregion

            #region Search
            hlAppli = new HyperLink();
            hlAppli.ID = "Search";
            hlAppli.CssClass = "applis";
            hlAppli.ImageUrl = "~/Images/seach_icon.png";
            hlAppli.NavigateUrl = "javascript:openMenu('Search');";
            hlAppli.Attributes.Add("onmouseover", "tooltipOn('Search')");
            hlAppli.Attributes.Add("onmouseout", "tooltipOut('Search')");
            pnlApplications.Controls.Add(hlAppli);

            tooltip = new Label();
            tooltip.CssClass = "tooltip";
            tooltip.ID = "SearchTooltip";
            tooltip.Text = "Rechercher";
            tooltip.Style.Add("top", "91%");
            tooltip.Style.Add("left", "46%");
            main.Controls.Add(tooltip);
            #endregion

            #region Fichiers
            hlAppli = new HyperLink();
            hlAppli.ID = "Fichiers";
            hlAppli.CssClass = "applis";
            hlAppli.ImageUrl = "~/Images/Files.png";
            hlAppli.NavigateUrl = "javascript:openMenu('Fichiers');";
            hlAppli.Attributes.Add("onmouseover", "tooltipOn('Fichiers')");
            hlAppli.Attributes.Add("onmouseout", "tooltipOut('Fichiers')");
            pnlApplications.Controls.Add(hlAppli);

            tooltip = new Label();
            tooltip.CssClass = "tooltip";
            tooltip.ID = "FichiersTooltip";
            tooltip.Text = "Fichiers";
            tooltip.Style.Add("top", "91%");
            tooltip.Style.Add("left", "49%");
            main.Controls.Add(tooltip);

            Panel pnlFichers = new Panel();
            pnlFichers.ID = "pnlFichiers";
            pnlFichers.Style.Add("position", "absolute");
            pnlFichers.Style.Add("font-family", "'Segoe UI Variable Text'");
            pnlFichers.Style.Add("display", "grid");
            pnlFichers.Style.Add("User-select", "none");
            pnlFichers.Style.Add("transform", "scale(0.2)");
            pnlFichers.Style.Add("z-index", "-1");
            pnlFichers.Style.Add("padding", "6px");
            pnlFichers.Style.Add("border-radius", "6px");
            pnlFichers.Style.Add("background-color", "#f0f0f0");
            pnlFichers.Style.Add("top", "88%");
            pnlFichers.Style.Add("left", "47.5%");
            pnlFichers.Style.Add("transition", "0.3s");

            HyperLink hlFichier = new HyperLink();
            hlFichier.ID = "hlprojet1";
            hlFichier.Text = "Outil de gestion";
            hlFichier.NavigateUrl = "javascript:openFichier(0);";
            hlFichier.Style.Add("padding", "2px");
            hlFichier.Style.Add("border-radius", "3px");
            pnlFichers.Controls.Add(hlFichier);

            hlFichier = new HyperLink();
            hlFichier.ID = "hlprojet2";
            hlFichier.Text = "Sous-partie outil de gestion";
            hlFichier.NavigateUrl = "javascript:openFichier(1);";
            hlFichier.Style.Add("padding", "2px");
            hlFichier.Style.Add("border-radius", "3px");
            pnlFichers.Controls.Add(hlFichier);

            hlFichier = new HyperLink();
            hlFichier.ID = "hlprojet3";
            hlFichier.Text = "Gestion QR-Code";
            hlFichier.NavigateUrl = "javascript:openFichier(2);";
            hlFichier.Style.Add("padding", "2px");
            hlFichier.Style.Add("border-radius", "3px");
            pnlFichers.Controls.Add(hlFichier);

            hlFichier = new HyperLink();
            hlFichier.ID = "hlprojet4";
            hlFichier.Text = "StreamIO";
            hlFichier.NavigateUrl = "javascript:openFichier(3);";
            hlFichier.Style.Add("padding", "2px");
            hlFichier.Style.Add("border-radius", "3px");
            pnlFichers.Controls.Add(hlFichier);

            hlFichier = new HyperLink();
            hlFichier.ID = "hlprojet5";
            hlFichier.Text = "GLPI";
            hlFichier.NavigateUrl = "javascript:openFichier(4);";
            hlFichier.Style.Add("padding", "2px");
            hlFichier.Style.Add("border-radius", "3px");
            pnlFichers.Controls.Add(hlFichier);

            hlFichier = new HyperLink();
            hlFichier.ID = "hlprojet6";
            hlFichier.Text = "Linked'in";
            hlFichier.NavigateUrl = "javascript:openFichier(5);";
            hlFichier.Style.Add("padding", "2px");
            hlFichier.Style.Add("border-radius", "3px");
            pnlFichers.Controls.Add(hlFichier);

            hlFichier = new HyperLink();
            hlFichier.ID = "hlprojet7";
            hlFichier.Text = "Audit RGPD";
            hlFichier.NavigateUrl = "javascript:openFichier(6);";
            hlFichier.Style.Add("padding", "2px");
            hlFichier.Style.Add("border-radius", "3px");
            pnlFichers.Controls.Add(hlFichier);

            hlFichier = new HyperLink();
            hlFichier.ID = "hlprojet8";
            hlFichier.Text = "IA interactive";
            hlFichier.NavigateUrl = "javascript:openFichier(7);";
            hlFichier.Style.Add("padding", "2px");
            hlFichier.Style.Add("border-radius", "3px");
            pnlFichers.Controls.Add(hlFichier);

            main.Controls.Add(pnlFichers);
            #endregion

            #region Veille
            hlAppli = new HyperLink();
            hlAppli.ID = "Veille";
            hlAppli.CssClass = "applis";
            hlAppli.ImageUrl = "~/Images/Mail.png";
            hlAppli.NavigateUrl = "javascript:openMenu('Veille');";
            hlAppli.Attributes.Add("onmouseover", "tooltipOn('Veille')");
            hlAppli.Attributes.Add("onmouseout", "tooltipOut('Veille')");
            pnlApplications.Controls.Add(hlAppli);

            tooltip = new Label();
            tooltip.CssClass = "tooltip";
            tooltip.ID = "VeilleTooltip";
            tooltip.Text = "Veille";
            tooltip.Style.Add("top", " 91%");
            tooltip.Style.Add("left", "51.5%");
            main.Controls.Add(tooltip);

            Panel pnlVeille = new Panel();
            pnlVeille.ID = "pnlVeille";
            pnlVeille.Style.Add("position", "absolute");
            pnlVeille.Style.Add("font-family", "'Segoe UI Variable Text'");
            pnlVeille.Style.Add("text-decoration", "none");
            pnlVeille.Style.Add("display", "grid");
            pnlVeille.Style.Add("User-select", "none");
            pnlVeille.Style.Add("transform", "scale(0.5)");
            pnlVeille.Style.Add("z-index", "-1");
            pnlVeille.Style.Add("padding", "6px");
            pnlVeille.Style.Add("border-radius", "6px");
            pnlVeille.Style.Add("background-color", "#f0f0f0");
            pnlVeille.Style.Add("top", "93%");
            pnlVeille.Style.Add("left", "50%");
            pnlVeille.Style.Add("transition", "0.3s");

            HyperLink hlVeille = new HyperLink();
            hlVeille.ID = "hlVeille";
            hlVeille.Text = "Veille Pompier";
            hlVeille.NavigateUrl = "javascript:openVeille('pnlVeillePompier0');";
            hlVeille.Style.Add("padding", "2px");
            hlVeille.Style.Add("border-radius", "3px");
            hlVeille.Style.Add("text-decoration", "none");
            hlVeille.Style.Add("color", "black");
            pnlVeille.Controls.Add(hlVeille);

            main.Controls.Add(pnlVeille);
            #endregion

            #region VisualStudio
            hlAppli = new HyperLink();
            hlAppli.ID = "VisualStudio";
            hlAppli.CssClass = "applis";
            hlAppli.ImageUrl = "~/Images/Visual_Studio_Icon_petit.png";
            hlAppli.NavigateUrl = "javascript:openMenu('VisualStudio');";
            hlAppli.Attributes.Add("onmouseover", "tooltipOn('VisualStudio')");
            hlAppli.Attributes.Add("onmouseout", "tooltipOut('VisualStudio')");
            pnlApplications.Controls.Add(hlAppli);

            tooltip = new Label();
            tooltip.CssClass = "tooltip";
            tooltip.ID = "VisualStudioTooltip";
            tooltip.Text = "Mes outils et langages maitrisés";
            tooltip.Style.Add("top", "91%");
            tooltip.Style.Add("left", "54%");
            main.Controls.Add(tooltip);
            #endregion

            footer.Controls.Add(pnlApplications);
            #endregion

            #region Outils
            Panel pnlOutils = new Panel();
            pnlOutils.Style.Add("grid-column-start", "3");
            pnlOutils.Style.Add("display", "grid");
            pnlOutils.Style.Add("grid-template-columns", "repeat(3,auto)");
            pnlOutils.Style.Add("justify-content", "end");
            pnlOutils.Style.Add("align-items", "center");
            pnlOutils.Style.Add("column-gap", "3%");
            pnlOutils.Style.Add("padding-right", "3%");

            #region Menu eject USB
            HyperLink hlOutils = new HyperLink();
            hlOutils.ID = "pnlmenu";
            hlOutils.CssClass = "outils";
            hlOutils.ImageUrl = "~/Images/up_arrow.png";
            hlOutils.Attributes.Add("onmouseover", "tooltipOn('menu')");
            hlOutils.Attributes.Add("onmouseout", "tooltipOut('menu')");
            hlOutils.NavigateUrl = "javascript:openMenuUSB();";
            pnlOutils.Controls.Add(hlOutils);

            tooltip = new Label();
            tooltip.CssClass = "tooltip";
            tooltip.ID = "menuTooltip";
            tooltip.Text = "Afficher les icônes cachées";
            tooltip.Style.Add("top", "91%");
            tooltip.Style.Add("left", "86.4%");
            main.Controls.Add(tooltip);

            Panel pnlMenuOpen = new Panel();
            pnlMenuOpen.ID = "pnlMenuOpen";
            pnlMenuOpen.Style.Add("display", "grid");
            pnlMenuOpen.Style.Add("opacity", "0.9");
            pnlMenuOpen.Style.Add("width", "2.5%");
            pnlMenuOpen.Style.Add("height", "5%");
            pnlMenuOpen.Style.Add("grid-template-columns", "25px auto auto");
            pnlMenuOpen.Style.Add("justify-content", "center");
            pnlMenuOpen.Style.Add("align-items", "center");
            pnlMenuOpen.Style.Add("column-gap", "20%");
            pnlMenuOpen.Style.Add("position", "absolute");
            pnlMenuOpen.Style.Add("left", "88.8%");
            pnlMenuOpen.Style.Add("top", "93%");
            pnlMenuOpen.Style.Add("transition", "0.5s");
            pnlMenuOpen.Style.Add("z-index", "-1");
            pnlMenuOpen.Style.Add("border-radius", "10px");
            pnlMenuOpen.Style.Add("background-color", "#f0f0f0");

            HyperLink hlUSBMenu = new HyperLink();
            hlUSBMenu.ID = "hlUSBeject";
            hlUSBMenu.NavigateUrl = "javascript:openMenuEject();";
            hlUSBMenu.CssClass = "usbMenu";
            hlUSBMenu.ImageUrl = "~/Images/USB_eject.png";
            pnlMenuOpen.Controls.Add(hlUSBMenu);

            hlUSBMenu = new HyperLink();
            hlUSBMenu.ID = "hlWindDef";
            hlUSBMenu.NavigateUrl = "";
            hlUSBMenu.CssClass = "usbMenu";
            hlUSBMenu.ImageUrl = "~/Images/windows_defender.png";
            pnlMenuOpen.Controls.Add(hlUSBMenu);

            Panel pnlMenuEject = new Panel();
            pnlMenuEject.ID = "pnlMenuEject";
            pnlMenuEject.Style.Add("visibility", "hidden");
            pnlMenuEject.Style.Add("opacity", "0");
            pnlMenuEject.Style.Add("display", "grid");
            pnlMenuEject.Style.Add("position", "absolute");
            pnlMenuEject.Style.Add("top", "82.5%");
            pnlMenuEject.Style.Add("left", "87.67%");
            pnlMenuEject.Style.Add("grid-template-rows", "auto auto");
            pnlMenuEject.Style.Add("grid-template-columns", "auto auto");
            pnlMenuEject.Style.Add("background-color", "#f9f9f9");
            pnlMenuEject.Style.Add("padding", "6px");
            pnlMenuEject.Style.Add("border-radius", "5px");
            pnlMenuEject.Style.Add("z-index", "1");
            pnlMenuEject.Style.Add("transition", "0.3s");
            pnlMenuEject.Style.Add("user-select", "none");
            pnlMenuEject.Style.Add("font-family", "'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif");

            System.Web.UI.WebControls.Image imgImprimante = new System.Web.UI.WebControls.Image();
            imgImprimante.ImageUrl = "~/Images/imprimante_32.png";
            imgImprimante.Width = Unit.Pixel(15);
            imgImprimante.Style.Add("padding", "0px 12px 6px 0px");
            imgImprimante.Style.Add("border-bottom", "1px solid #787878");
            pnlMenuEject.Controls.Add(imgImprimante);

            Label lbEject = new Label();
            lbEject.Text = "Ouvrir Périphériques et imprimantes";
            lbEject.Style.Add("border-bottom", "1px solid #787878");
            lbEject.Style.Add("grid-column-start", "2");
            lbEject.Style.Add("font-weight", "600");
            lbEject.Style.Add("font-size", "11px");
            pnlMenuEject.Controls.Add(lbEject);

            System.Web.UI.WebControls.Image imgDrive = new System.Web.UI.WebControls.Image();
            imgDrive.ImageUrl = "~/Images/drive.png";
            imgDrive.Width = Unit.Pixel(16);
            imgDrive.Style.Add("padding-top", "5px");
            pnlMenuEject.Controls.Add(imgDrive);

            Panel pnlEject = new Panel();
            pnlEject.Style.Add("display", "grid");
            pnlEject.Style.Add("grid-column-start", "2");
            pnlEject.Style.Add("grid-template-rows", "auto auto");
            pnlEject.Style.Add("padding", "4px 4px 4px 0px");

            HyperLink hlEject = new HyperLink();
            hlEject.ID = "hlEject";
            hlEject.Text = "Ejecter Mass Storage";
            hlEject.Style.Add("font-size", "12px");
            hlEject.Style.Add("text-decoration", "none");
            hlEject.Style.Add("color", "black");
            hlEject.Style.Add("margin-bottom", "4px");
            hlEject.NavigateUrl = "javascript:closeProject();";
            pnlEject.Controls.Add(hlEject);

            lbEject = new Label();
            lbEject.Text = " - PORTFOLIO (D:)";
            lbEject.Style.Add("font-size", "12px");
            lbEject.Style.Add("padding-left", "6px");
            lbEject.Style.Add("color", "#8a8a8a");
            pnlEject.Controls.Add(lbEject);

            pnlMenuEject.Controls.Add(pnlEject);
            main.Controls.Add(pnlMenuEject);

            main.Controls.Add(pnlMenuOpen);

            #endregion

            #region WifiSoundBatterie

            hlOutils = new HyperLink();
            hlOutils.ID = "WifiSoundBatterie";
            hlOutils.CssClass = "outils";
            hlOutils.Attributes.Add("onmouseover", "tooltipOn('WifiSoundBatterie')");
            hlOutils.Attributes.Add("onmouseout", "tooltipOut('WifiSoundBatterie')");
            hlOutils.ImageUrl = "~/Images/wifi_sound_batterie.png";
            pnlOutils.Controls.Add(hlOutils);

            tooltip = new Label();
            tooltip.CssClass = "tooltip";
            tooltip.ID = "WifiSoundBatterieTooltip";
            tooltip.Text = "Wifi: Connecté <br> Son: 100% <br> Batterie: 90%";
            tooltip.Style.Add("top", "87.8%");
            tooltip.Style.Add("left", "91%");
            main.Controls.Add(tooltip);

            #endregion

            #region DateTime
            DateTime dateTime = DateTime.Now;

            hlOutils = new HyperLink();
            hlOutils.ID = "Calendar";
            hlOutils.CssClass = "outils";
            hlOutils.Attributes.Add("onmouseover", "tooltipOn('Calendar')");
            hlOutils.Attributes.Add("onmouseout", "tooltipOut('Calendar')");
            hlOutils.Style.Add("font-family", "'Segoe UI Variable Text'");
            hlOutils.Style.Add("font-size", "12px");
            hlOutils.Style.Add("text-align", "right");
            hlOutils.Text = dateTime.ToShortTimeString() + "<br/>" + dateTime.ToShortDateString();
            //hlout.. = dateTime.ToString("HH:mm") + "<br/>" + dateTime.ToString("dd/MM/yyyy");
            pnlOutils.Controls.Add(hlOutils);

            tooltip = new Label();
            tooltip.CssClass = "tooltip";
            tooltip.ID = "CalendarTooltip";
            tooltip.Text = dateTime.ToString();
            tooltip.Style.Add("top", "91%");
            tooltip.Style.Add("left", "93.5%");
            main.Controls.Add(tooltip);
            footer.Controls.Add(pnlOutils);

            #endregion
            #endregion
            #endregion

            #region Arret
            Panel pnlFondBleu = new Panel();
            pnlFondBleu.ID = "pnlFondBleu";
            pnlFondBleu.Style.Add("background-color", "#005B9E");
            pnlFondBleu.Style.Add("position", "absolute");
            pnlFondBleu.Style.Add("width", "100vw");
            pnlFondBleu.Style.Add("height", "100vh");
            pnlFondBleu.Style.Add("display", "none");
            pnlFondBleu.Style.Add("z-index", "100");
            main.Controls.Add(pnlFondBleu);

            Panel pnlArret = new Panel();
            pnlArret.CssClass = "loader";
            pnlArret.Style.Add("position", "absolute");
            pnlArret.Style.Add("z-index", "101");
            pnlArret.Style.Add("display", "none");
            main.Controls.Add(pnlArret);

            Label lbArret = new Label();
            lbArret.Text = "Arrêt en cours";
            lbArret.ID = "lbArret";
            lbArret.Style.Add("display", "none !important");
            lbArret.Style.Add("position", "absolute");
            lbArret.Style.Add("top", "55%");
            lbArret.Style.Add("justify-self", "center");
            lbArret.Style.Add("font-size", "36px");
            lbArret.Style.Add("color", "white");
            lbArret.Style.Add("z-index", "101");
            lbArret.Style.Add("padding-left", "8px");
            lbArret.Style.Add("font-family", "'Lucida Sans Unicode'");
            main.Controls.Add(lbArret);
            #endregion
        }
    }
}