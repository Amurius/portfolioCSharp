using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio
{
  public partial class AccueilPortfolio : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      #region Pc Portable 
      string lien = Request.Url.ToString();
      lien = lien.Substring(0, lien.LastIndexOf('/'));

      Image imgPC = new Image();
      imgPC.ImageUrl = "~/Images/PC_rgb.png";
      imgPC.Height = Unit.Percentage(100);

      Panel rgb = new Panel();
      rgb.ID = "rgb";
      rgb.Width = Unit.Percentage(29);
      rgb.Height = Unit.Percentage(44);
      rgb.Style.Add("position", "absolute");
      rgb.Style.Add("transition", "1.5s");
      rgb.Style.Add("background-color", "white");
      rgb.Style.Add("top", "53%");
      rgb.Style.Add("z-index", "-1");
      divPc.Controls.Add(rgb);
      divPc.Controls.Add(imgPC);

      HyperLink hlScreen = new HyperLink();
      hlScreen.ImageUrl = "~/Images/windows11_wallpaper.jpg";
      Random random = new Random();
      //javascript:window.open('Projet1.aspx', 'main', 'fullscreen=yes, directories=no, location=no, menubar=no, resizable=no, scrollbars=no, status=no, toolbar=no');
      hlScreen.NavigateUrl = "javascript:downloadURI('data:text,\"C://Program Files/Google/Chrome/Application/chrome.exe\" " + lien + "/enterPC.aspx --start-fullscreen' ,'" + random.Next() + ".chrome')";
      hlScreen.ID = "hlScreenDefault";
      hlScreen.CssClass = "hlScreen";
      hlScreen.Style.Add("display", "block !important");
      divPc.Controls.Add(hlScreen);

      hlScreen = new HyperLink();
      hlScreen.ImageUrl = "~/Images/screen_tableau.png";
      hlScreen.NavigateUrl = "javascript:downloadURI('data:text,\"C://Program Files/Google/Chrome/Application/chrome.exe\" " + lien + "/enterPC.aspx?projetid=0 --start-fullscreen' ,'" + random.Next() + ".chrome')";
      hlScreen.ID = "hlScreenProjet1";
      hlScreen.CssClass = "hlScreen";
      divPc.Controls.Add(hlScreen);

      hlScreen = new HyperLink();
      hlScreen.ImageUrl = "~/Images/AP3/objectif.png";
      hlScreen.NavigateUrl = "javascript:downloadURI('data:text,\"C://Program Files/Google/Chrome/Application/chrome.exe\" " + lien + "/enterPC.aspx?projetid=3 --start-fullscreen' ,'" + random.Next() + ".chrome')";
      hlScreen.ID = "hlScreenProjet2";
      hlScreen.CssClass = "hlScreen";
      divPc.Controls.Add(hlScreen);

      hlScreen = new HyperLink();
      hlScreen.ImageUrl = "~/Images/code-programme-informatique.jpg";
      hlScreen.NavigateUrl = "javascript:downloadURI('data:text,\"C://Program Files/Google/Chrome/Application/chrome.exe\" " + lien + "/enterPC.aspx?projetid=2 --start-fullscreen' ,'" + random.Next() + ".chrome')";
      hlScreen.ID = "hlScreenProjet3";
      hlScreen.CssClass = "hlScreen";
      divPc.Controls.Add(hlScreen);
      #endregion

      #region Zone du millieu

      #region Image Stylos
      Image imgStylos = new Image();
      imgStylos.ID = "imgStylos";
      imgStylos.ImageUrl = "~/Images/Stylos2.png";
      //divMiddle.Controls.Add(imgStylos);
      #endregion

      #region Clés USB

      Panel pnlUSB = new Panel();
      pnlUSB.Style.Add("height", "100%");
      pnlUSB.Style.Add("position", "relative");
      pnlUSB.Style.Add("display", "grid");
      pnlUSB.Style.Add("grid-row-start", "3");
      pnlUSB.Style.Add("align-content", "flex-end");
      pnlUSB.Style.Add("grid-template-rows", "min-content min-content min-content");


      Label lbUSB = new Label();
      lbUSB.ID = "lbPortfolio";
      lbUSB.Text = "PortFolio";
      lbUSB.Style.Add("color", "black");
      lbUSB.Style.Add("transition", "1s");
      lbUSB.Style.Add("font-weight", "bold");
      lbUSB.Style.Add("font-size", "26px");
      lbUSB.Style.Add("padding", "1rem");
      lbUSB.Style.Add("grid-row-start", "2");
      lbUSB.Style.Add("align-self", "flex-end");
      lbUSB.Style.Add("text-decoration", "underline");
      lbUSB.Style.Add("border-radius", "12px");
      pnlPortfolio.Controls.Add(lbUSB);
      pnlPortfolio.Controls.Add(pnlUSB);

      HyperLink hlUSB = new HyperLink();
      hlUSB.NavigateUrl = "javascript:chooseUSBrouge();";
      hlUSB.ID = "hlUsbRouge";
      hlUSB.Style.Add("top", "25%");
      hlUSB.Style.Add("left", "28%");
      pnlUSB.Controls.Add(hlUSB);

      lbUSB = new Label();
      lbUSB.ID = "lbUSBRouge";
      lbUSB.CssClass = "lbUSB";
      lbUSB.Text = "Gestion d'écrans";
      pnlUSB.Controls.Add(lbUSB);

      Image imgUSB = new Image();
      imgUSB.ImageUrl = "~/Images/cle_usb_rouge.png";
      imgUSB.ID = "USBrouge";
      imgUSB.Width = Unit.Percentage(43);
      pnlUSB.Controls.Add(imgUSB);

      hlUSB = new HyperLink();
      hlUSB.NavigateUrl = "javascript:chooseUSBverte();";
      hlUSB.ID = "hlUsbVerte";
      hlUSB.Style.Add("top", "53%");
      hlUSB.Style.Add("left", "28%");
      pnlUSB.Controls.Add(hlUSB);

      lbUSB = new Label();
      lbUSB.ID = "lbUSBVerte";
      lbUSB.CssClass = "lbUSB";
      lbUSB.Text = "StreamIO";
      pnlUSB.Controls.Add(lbUSB);

      imgUSB = new Image();
      imgUSB.ImageUrl = "~/Images/cle_usb_verte.png";
      imgUSB.Width = Unit.Percentage(43);
      imgUSB.ID = "USBverte";
      pnlUSB.Controls.Add(imgUSB);

      hlUSB = new HyperLink();
      hlUSB.NavigateUrl = "javascript:chooseUSBviolet();";
      hlUSB.ID = "hlUsbViolet";
      hlUSB.Style.Add("top", "80%");
      hlUSB.Style.Add("left", "28%");
      pnlUSB.Controls.Add(hlUSB);

      lbUSB = new Label();
      lbUSB.ID = "lbUSBViolet";
      lbUSB.CssClass = "lbUSB";
      lbUSB.Text = "QR-Code";
      pnlUSB.Controls.Add(lbUSB);

      imgUSB = new Image();
      imgUSB.ImageUrl = "~/Images/cle_usb_violet.png";
      imgUSB.Width = Unit.Percentage(43);
      imgUSB.ID = "USBviolet";
      pnlUSB.Controls.Add(imgUSB);

      HyperLink hlUnplug = new HyperLink();
      hlUnplug.ID = "hlUnplug";
      hlUnplug.Style.Add("position", "absolute");
      hlUnplug.Style.Add("top", "32.5%");
      hlUnplug.Style.Add("left", "-19.5%");
      hlUnplug.Style.Add("width", "37%");
      hlUnplug.Style.Add("height", "11%");
      hlUnplug.Style.Add("z-index", "15");
      hlUnplug.NavigateUrl = "";
      pnlUSB.Controls.Add(hlUnplug);
      #endregion

      #endregion

      #region divPaper
      #region Etiquette
      Panel pnlEtiquette = new Panel();
      pnlEtiquette.ID = "pnlEtiquette";


      Label lbEtiquette = new Label();
      lbEtiquette.Text = "Bureau de Artus LAVIE-RICHARD";
      lbEtiquette.Style.Add("font-weight", "bold");
      lbEtiquette.Style.Add("justify-self", "center");
      lbEtiquette.Style.Add("margin-top", "8px");
      lbEtiquette.Style.Add("font-size", "18px");
      pnlEtiquette.Controls.Add(lbEtiquette);

      lbEtiquette = new Label();
      lbEtiquette.Text = "Etudiant en BTS SIO <br> Option choisie : SLAM <br> Alternant chez MI7 chez SicreLemaire";
      lbEtiquette.Style.Add("justify-self", "center");
      lbEtiquette.Style.Add("font-size", "14px");
      pnlEtiquette.Controls.Add(lbEtiquette);
      #endregion

      #region Lampe
      Image rond = new Image();
      rond.ImageUrl = "~/Images/img.png";
      rond.ID = "rondLumiere";
      divPaper.Controls.Add(rond);

      rond = new Image();
      rond.ImageUrl = "~/Images/img.png";
      rond.ID = "rondNoir";
      divPaper.Controls.Add(rond);

      divPaper.Controls.Add(pnlEtiquette);
      #endregion

      #region CommandeRGB

      Panel telecomande = new Panel();
      telecomande.BackImageUrl = "~/Images/commandeRGB.png";
      telecomande.Width = Unit.Pixel(148);
      telecomande.Height = Unit.Pixel(240);
      telecomande.Style.Add("grid-row-start", "2");
      telecomande.Style.Add("justify-self", "end");
      telecomande.Style.Add("align-self", "end");
      telecomande.Style.Add("position", "relative");
      telecomande.Style.Add("margin", "1%");
      telecomande.Style.Add("z-index", "10");
      telecomande.Style.Add("background-size", "contain");
      telecomande.Style.Add("background-repeat", "no-repeat");

      HyperLink hlChangeColor = new HyperLink();
      for (int i = 0; i < 11; i++)
      {
        hlChangeColor = new HyperLink();
        hlChangeColor.ID = "hlChangeColor"+i;
        hlChangeColor.Width = Unit.Percentage(23);
        hlChangeColor.Height = Unit.Percentage(14);
        hlChangeColor.Style.Add("position", "absolute");
        telecomande.Controls.Add(hlChangeColor);

        switch (i)
        {
          case 0:
            hlChangeColor.NavigateUrl = "javascript:switchOn();";
            hlChangeColor.ToolTip = "On/Off";
            hlChangeColor.Style.Add("top", "6%");
            hlChangeColor.Style.Add("left", "10%");
            break;
          case 1:
            hlChangeColor.NavigateUrl = "javascript:changeColor(1);";
            hlChangeColor.Style.Add("top", "41%");
            hlChangeColor.Style.Add("left", "37.6%");
            break;
          case 2:
            hlChangeColor.NavigateUrl = "javascript:changeColor(2);";
            hlChangeColor.Style.Add("top", "56%");
            hlChangeColor.Style.Add("left", "12%");
            break;
          case 3:
            hlChangeColor.NavigateUrl = "javascript:changeColor(3);";
            hlChangeColor.Style.Add("top", "56%");
            hlChangeColor.Style.Add("left", "37.6%");
            break;
          case 4:
            hlChangeColor.NavigateUrl = "javascript:changeColor(4);";
            hlChangeColor.Style.Add("top", "56%");
            hlChangeColor.Style.Add("left", "63%");
            break;
          case 5:
            hlChangeColor.NavigateUrl = "javascript:changeColor(5);";
            hlChangeColor.Style.Add("top", "71%");
            hlChangeColor.Style.Add("left", "12%");
            break;
          case 6:
            hlChangeColor.NavigateUrl = "javascript:changeColor(6);";
            hlChangeColor.Style.Add("top", "71%");
            hlChangeColor.Style.Add("left", "37.6%");
            break;
          case 7:
            hlChangeColor.NavigateUrl = "javascript:changeColor(7);";
            hlChangeColor.Style.Add("top", "71%");
            hlChangeColor.Style.Add("left", "63%");
            break;
          case 8:
            hlChangeColor.NavigateUrl = "javascript:speedDown();";
            hlChangeColor.Style.Add("top", "27%");
            hlChangeColor.Style.Add("left", "10%");
            break;
          case 9:
            hlChangeColor.NavigateUrl = "javascript:raimbow();";
            hlChangeColor.Style.Add("top", "27%");
            hlChangeColor.Style.Add("left", "37.6%");
            break;
          case 10:
            hlChangeColor.NavigateUrl = "javascript:speedUp();";
            hlChangeColor.Style.Add("top", "27%");
            hlChangeColor.Style.Add("left", "65%");
            break;
        }
      }
      divPaper.Controls.Add(telecomande);
      #endregion

      #region Footer
      Label lbFooter = new Label();
      lbFooter.Text = "© LAVIE-RICHARD Artus 2024";
      lbFooter.ID = "lbFooter";
      lbFooter.Style.Add("transition", "1s");
      lbFooter.Style.Add("width", "max-content");
      lbFooter.Style.Add("justify-self", "end");
      lbFooter.Style.Add("padding", "2px 6px");
      lbFooter.Style.Add("border-radius", "6px");
      lbFooter.Style.Add("margin-right", "6px");
      divPaper.Controls.Add(lbFooter);
      #endregion
      #endregion

      #region EcranPetit

      Label lb = new Label();
      lb.ID = "ecranPcPetit";
      lb.Style.Add("display", "none");
      lb.Text = "Veuillez mettre la page en fenêtré plein ecran merci :) !";
      main.Controls.Add(lb);
      #endregion
    }
  }
}