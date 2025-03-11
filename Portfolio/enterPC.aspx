<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="enterPC.aspx.cs" Inherits="Portfolio.enterPC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
    <script type="text/javascript">

        refreshTime = 0;

        setInterval(() => {
            refreshTime--;
            if (refreshTime <= 0) {
                ladate = new Date();
                if (ladate.getDate() < 10 && (ladate.getMonth() + 1) < 10) {
                    date = "0" + ladate.getDate() + "/0" + (ladate.getMonth() + 1) + "/" + ladate.getFullYear();
                } else if ((ladate.getMonth() + 1) < 10) {
                    date = ladate.getDate() + "/0" + (ladate.getMonth() + 1) + "/" + ladate.getFullYear();
                } else if (ladate.getDate() < 10) {
                    date = "0" + ladate.getDate() + "/" + (ladate.getMonth() + 1) + "/" + ladate.getFullYear();
                } else {
                    date = ladate.getDate() + "/" + (ladate.getMonth() + 1) + "/" + ladate.getFullYear();
                }
                if (ladate.getHours() < 10 && ladate.getMinutes() < 10) {
                    heures = "0" + ladate.getHours() + ":0" + ladate.getMinutes();
                } else if (ladate.getHours() < 10) {
                    heures = "0" + ladate.getHours() + ":" + ladate.getMinutes();
                } else if (ladate.getMinutes() < 10) {
                    heures = ladate.getHours() + ":0" + ladate.getMinutes();
                } else {
                    heures = ladate.getHours() + ":" + ladate.getMinutes();
                }
                var heureETdate = heures + "<br/>" + date;
                document.getElementById("Calendar").innerHTML = heures + "<br/>" + date;
            }
        }, 1000);

        function sleep(ms) {
            return new Promise(resolve => setTimeout(resolve, ms));
        }

        function openFichier(id) {
            pnl = "pnlProjet" + id;
            page = 0;
            document.getElementById(pnl).style.transition = "0.3s";
            document.getElementById("pnlVisualStudio").classList.remove("openMenuVisualStudio");
            if (document.getElementById(pnl).style.visibility == "visible") {
                document.getElementById(pnl).className = "pnlProjets";
                document.getElementById(pnl).style.visibility = "hidden";
                document.getElementById(pnl).style.transform = "scale(0.05)";
                document.getElementById(pnl).style.opacity = "0";
                document.getElementById(pnl).style.top = "50%";
                document.getElementById("pnlFichiers").className = "";
                document.getElementById("hlPrecedent").style.display = "none";
                document.getElementById("hlNext").style.display = "none";
                const documents = document.getElementsByClassName("pnlDocumentsP" + id);
                for (i = 0; i < documents.length; i++) {
                    documents[i].style.display = "none";
                    documents[i].className = "pnlDocumentsP" + id;
                }
            } else {
                if (id == 0) {
                    closeProject(1);
                    closeProject(2);
                    closeProject(3);
                    closeProject(4);
                    closeProject(5);
                    closeProject(6);
                    closeProject(7);
                    closeProject(8);
                } else if (id == 1) {
                    closeProject(0);
                    closeProject(2);
                    closeProject(3);
                    closeProject(4);
                    closeProject(5);
                    closeProject(6);
                    closeProject(7);
                    closeProject(8);
                } else if (id == 2) {
                    closeProject(0);
                    closeProject(1);
                    closeProject(3);
                    closeProject(4);
                    closeProject(5);
                    closeProject(6);
                    closeProject(7);
                    closeProject(8);
                } else if (id == 3) {
                    closeProject(0);
                    closeProject(1);
                    closeProject(2);
                    closeProject(4);
                    closeProject(5);
                    closeProject(6);
                    closeProject(7);
                    closeProject(8);
                } else if (id == 4) {
                    closeProject(0);
                    closeProject(1);
                    closeProject(2);
                    closeProject(3);
                    closeProject(5);
                    closeProject(6);
                    closeProject(7);
                    closeProject(8);
                } else if (id == 5) {
                    closeProject(0);
                    closeProject(1);
                    closeProject(2);
                    closeProject(3);
                    closeProject(4);
                    closeProject(6);
                    closeProject(7);
                    closeProject(8);
                } else if (id == 6) {
                    closeProject(0);
                    closeProject(1);
                    closeProject(2);
                    closeProject(3);
                    closeProject(4);
                    closeProject(5);
                    closeProject(7);
                    closeProject(8);
                } else if (id == 7) {
                    closeProject(0);
                    closeProject(1);
                    closeProject(2);
                    closeProject(3);
                    closeProject(4);
                    closeProject(5);
                    closeProject(6);
                    closeProject(8);
                } else if (id == 8) {
                    closeProject(0);
                    closeProject(1);
                    closeProject(2);
                    closeProject(3);
                    closeProject(4);
                    closeProject(5);
                    closeProject(6);
                    closeProject(7);
                }
                sleep(300).then(() => {
                    document.getElementById(pnl).style.visibility = "visible";
                    document.getElementById(pnl).style.transform = "scale(1)";
                    document.getElementById(pnl).style.opacity = "1";
                    document.getElementById(pnl).style.top = "0";
                    document.getElementById("pnlFichiers").className = "";
                    document.getElementById("hlPrecedent").style.display = "block";
                    document.getElementById("hlPrecedent").setAttribute("href", "javascript:Precedent('" + id + "');");
                    document.getElementById("hlNext").style.display = "block";
                    document.getElementById("hlNext").setAttribute("href", "javascript:Next('" + id + "');");
                    const documents = document.getElementsByClassName("pnlDocumentsP" + id);
                    for (i = 0; i < documents.length; i++) {
                        documents[i].style.display = "flex";
                    }
                    sleep(300).then(() => {
                        document.getElementById(pnl).style.transition = "1s";
                    });
                });
            }
        }

        function openMenuUSB() {
            document.getElementById("pnlFichiers").className = "";
            document.getElementById("pnlWindows").className = "";
            projetOuvert();
            if (document.getElementById("pnlmenu").firstChild.classList.contains("btnOpenMenuUSB")) {
                document.getElementById("pnlmenu").firstChild.className = "outils";
                document.getElementById("pnlMenuOpen").className = "";
                document.getElementById("menuTooltip").style.visibility = "visible";
                document.getElementById("pnlMenuEject").className = "";
            } else {
                document.getElementById("pnlmenu").firstChild.className = "outils btnOpenMenuUSB";
                document.getElementById("pnlMenuOpen").className = "openMenuUSB";
                document.getElementById("menuTooltip").style.visibility = "hidden";
            }
        }

        function projetOuvert() {
            if (document.getElementById("pnlProjet0").style.visibility == "visible" || document.getElementById("pnlProjet1").style.visibility == "visible" || document.getElementById("pnlProjet2").style.visibility == "visible") {
                document.getElementById("hlUSBeject").style.display = "block";
                document.getElementById("hlWindDef").style.position = "unset";
                document.getElementById("hlWindDef").style.padding = "50% 50% 30% 50%";
                document.getElementById("pnlMenuOpen").style.width = "5%";
                document.getElementById("pnlMenuOpen").style.left = "87.8%";
            } else {
                document.getElementById("hlUSBeject").style.display = "none";
                document.getElementById("hlWindDef").style.padding = "20% 20% 13% 20%";
                document.getElementById("pnlMenuOpen").style.width = "2.5%";
                document.getElementById("pnlMenuOpen").style.left = "88.8%";
                sleep(100).then(() => {
                    document.getElementById("hlWindDef").style.position = "absolute";
                });
            }
        }

        function closeProject(id) {
            const projets = document.getElementsByClassName("pnlProjets");
            document.getElementById("hlPrecedent").style.display = "none";
            document.getElementById("hlNext").style.display = "none";
            for (i = 0; i < projets.length; i++) {
                projets[i].classList.remove("Next")
                projets[i].style.transition = "0.3s";
                projets[i].style.visibility = "hidden";
                projets[i].style.transform = "scale(0.05)";
                projets[i].style.opacity = "0";
                projets[i].style.top = "50%";
            }
            document.getElementById("pnlMenuEject").className = "";
            document.getElementById("pnlmenu").firstChild.className = "outils";
            for (j = 0; j < projets.length; j++) {
                var documents = document.getElementsByClassName("pnlDocumentsP" + id);
                for (i = 0; i < documents.length; i++) {
                    documents[i].style.display = "none";
                    documents[i].className = "pnlDocumentsP" + id;
                }
            }
            projetOuvert();
            sleep(200).then(() => {
                document.getElementById("pnlMenuOpen").className = "";
            });
        }

        function openMenuEject() {
            if (document.getElementById("pnlMenuEject").classList.contains("visible")) {
                document.getElementById("pnlMenuEject").className = "";
            } else document.getElementById("pnlMenuEject").className = "visible";
        }

        function openMenu(id) {
            pnl = "pnl" + id;
            classOpen = "openMenu" + id;
            tooltip = id + "Tooltip";
            var doc = document.getElementsByClassName("pnlblack");

            if (document.getElementById(pnl).className == "") {
                closeAll();
            }
            document.getElementById(id).firstChild.className = "btnOpenMenu";
            sleep(150).then(() => {
                document.getElementById(id).firstChild.className = "";
            });
            if (document.getElementById(pnl).classList.contains(classOpen)) {
                document.getElementById(pnl).className = "";
                document.getElementById(tooltip).style.visibility = "visible";
                var cmd = document.getElementsByClassName("cmd");
                for (i = 0; i < cmd.length; i++) {
                    cmd[i].style.visibility = "hidden";
                    cmd[i].style.transform = "scale(0.05)";
                }
            } else {
                document.getElementById(tooltip).style.visibility = "hidden";
                if (id == "VisualStudio") {
                    closeProject(0);
                    closeProject(1);
                    closeProject(2);
                    for (i = 0; i < doc.length; i++) {
                        document.getElementById("pnlblack" + i).style.opacity = "1";
                    }
                    grille0 = 30;
                    pop = 34;
                    cmd = 0;
                    var openCMD = setInterval(function () {
                        pop--;
                        if (pop >= 0) {
                            cmd++;
                            if (cmd < 20) {
                                document.getElementById("cmd" + cmd).style.visibility = "visible";
                                document.getElementById("cmd" + cmd).style.transform = "scale(1)";
                            }
                        }
                        else {
                            cmd = 0;
                            clearInterval(openCMD);
                        }
                        if (cmd > 12) {
                            document.getElementById("cmd" + (cmd - 13)).style.visibility = "hidden";
                            document.getElementById("cmd" + (cmd - 13)).style.transform = "scale(0.05)";
                        }
                    }, 50);
                    sleep(1500).then(() => {
                        document.getElementById("blueScreen").style.display = "block";
                        sleep(2000).then(() => {
                            document.getElementById("blueScreen").style.display = "none";
                            document.getElementById(pnl).className = classOpen;
                            sleep(500).then(() => {
                                var carreNoir = setInterval(function () {
                                    if (grille0 >= 0) {
                                        grille0--;
                                        random = 417 + Math.floor(Math.random() * 5);
                                        random0 = 457 + Math.floor(Math.random() * 5);
                                        random1 = 497 + Math.floor(Math.random() * 5);
                                        random2 = 537 + Math.floor(Math.random() * 5);
                                        random3 = 577 + Math.floor(Math.random() * 5);
                                        id = "pnlblack" + random;
                                        id0 = "pnlblack" + random0;
                                        id1 = "pnlblack" + random1;
                                        id2 = "pnlblack" + random2;
                                        id3 = "pnlblack" + random3;
                                        document.getElementById(id).style.opacity = "0";
                                        document.getElementById(id0).style.opacity = "0";
                                        document.getElementById(id1).style.opacity = "0";
                                        document.getElementById(id2).style.opacity = "0";
                                        document.getElementById(id3).style.opacity = "0";
                                    } else {
                                        clearInterval(carreNoir);
                                    }
                                }, 100);
                                sleep(300).then(() => {
                                    grille1 = 50;
                                    var carreNoir1 = setInterval(function () {
                                        if (grille1 >= 0) {
                                            grille1--;
                                            random = 334 + Math.floor(Math.random() * 11);
                                            random0 = 374 + Math.floor(Math.random() * 11);
                                            random1 = 654 + Math.floor(Math.random() * 11);
                                            random2 = 694 + Math.floor(Math.random() * 11);
                                            random3 = 414 + Math.floor(Math.random() * 11);
                                            random4 = 454 + Math.floor(Math.random() * 11);
                                            random5 = 494 + Math.floor(Math.random() * 11);
                                            random6 = 534 + Math.floor(Math.random() * 11);
                                            random7 = 574 + Math.floor(Math.random() * 11);
                                            random8 = 614 + Math.floor(Math.random() * 11);
                                            random9 = 654 + Math.floor(Math.random() * 11);
                                            id = "pnlblack" + random;
                                            id0 = "pnlblack" + random0;
                                            id1 = "pnlblack" + random1;
                                            id2 = "pnlblack" + random2;
                                            id3 = "pnlblack" + random3;
                                            id4 = "pnlblack" + random4;
                                            id5 = "pnlblack" + random5;
                                            id6 = "pnlblack" + random6;
                                            id7 = "pnlblack" + random7;
                                            id8 = "pnlblack" + random8;
                                            id9 = "pnlblack" + random9;
                                            document.getElementById(id).style.opacity = "0";
                                            document.getElementById(id0).style.opacity = "0";
                                            document.getElementById(id1).style.opacity = "0";
                                            document.getElementById(id2).style.opacity = "0";
                                            document.getElementById(id3).style.opacity = "0";
                                            document.getElementById(id4).style.opacity = "0";
                                            document.getElementById(id5).style.opacity = "0";
                                            document.getElementById(id6).style.opacity = "0";
                                            document.getElementById(id7).style.opacity = "0";
                                            document.getElementById(id8).style.opacity = "0";
                                            document.getElementById(id9).style.opacity = "0";
                                        } else {
                                            clearInterval(carreNoir1);
                                        }
                                    }, 80);
                                    sleep(300).then(() => {
                                        grille2 = 100;
                                        var carreNoir2 = setInterval(function () {
                                            if (grille2 >= 0) {
                                                grille2--;
                                                random = 331 + Math.floor(Math.random() * 17);
                                                random0 = 371 + Math.floor(Math.random() * 17);
                                                random1 = 651 + Math.floor(Math.random() * 17);
                                                random2 = 691 + Math.floor(Math.random() * 17);
                                                random3 = 411 + Math.floor(Math.random() * 17);
                                                random4 = 451 + Math.floor(Math.random() * 17);
                                                random5 = 491 + Math.floor(Math.random() * 17);
                                                random6 = 531 + Math.floor(Math.random() * 17);
                                                random7 = 571 + Math.floor(Math.random() * 17);
                                                random8 = 611 + Math.floor(Math.random() * 17);
                                                random9 = 291 + Math.floor(Math.random() * 17);
                                                random10 = 251 + Math.floor(Math.random() * 17);
                                                random11 = 651 + Math.floor(Math.random() * 17);
                                                random12 = 691 + Math.floor(Math.random() * 17);
                                                random13 = 731 + Math.floor(Math.random() * 17);
                                                id = "pnlblack" + random;
                                                id0 = "pnlblack" + random0;
                                                id1 = "pnlblack" + random1;
                                                id2 = "pnlblack" + random2;
                                                id3 = "pnlblack" + random3;
                                                id4 = "pnlblack" + random4;
                                                id5 = "pnlblack" + random5;
                                                id6 = "pnlblack" + random6;
                                                id7 = "pnlblack" + random7;
                                                id8 = "pnlblack" + random8;
                                                id9 = "pnlblack" + random9;
                                                id10 = "pnlblack" + random10;
                                                id11 = "pnlblack" + random11;
                                                id12 = "pnlblack" + random12;
                                                id13 = "pnlblack" + random13;
                                                document.getElementById(id).style.opacity = "0";
                                                document.getElementById(id0).style.opacity = "0";
                                                document.getElementById(id1).style.opacity = "0";
                                                document.getElementById(id2).style.opacity = "0";
                                                document.getElementById(id3).style.opacity = "0";
                                                document.getElementById(id4).style.opacity = "0";
                                                document.getElementById(id5).style.opacity = "0";
                                                document.getElementById(id6).style.opacity = "0";
                                                document.getElementById(id7).style.opacity = "0";
                                                document.getElementById(id8).style.opacity = "0";
                                                document.getElementById(id9).style.opacity = "0";
                                                document.getElementById(id10).style.opacity = "0";
                                                document.getElementById(id11).style.opacity = "0";
                                                document.getElementById(id12).style.opacity = "0";
                                                document.getElementById(id13).style.opacity = "0";
                                            } else {
                                                clearInterval(carreNoir2);
                                            }
                                        }, 60);
                                        sleep(300).then(() => {
                                            grille3 = 100;
                                            var carreNoir3 = setInterval(function () {
                                                if (grille3 >= 0) {
                                                    grille3--;
                                                    random = 327 + Math.floor(Math.random() * 25);
                                                    random0 = 367 + Math.floor(Math.random() * 25);
                                                    random1 = 647 + Math.floor(Math.random() * 25);
                                                    random2 = 687 + Math.floor(Math.random() * 25);
                                                    random3 = 407 + Math.floor(Math.random() * 25);
                                                    random4 = 447 + Math.floor(Math.random() * 25);
                                                    random5 = 487 + Math.floor(Math.random() * 25);
                                                    random6 = 527 + Math.floor(Math.random() * 25);
                                                    random7 = 567 + Math.floor(Math.random() * 25);
                                                    random8 = 607 + Math.floor(Math.random() * 25);
                                                    random9 = 287 + Math.floor(Math.random() * 25);
                                                    random10 = 247 + Math.floor(Math.random() * 25);
                                                    random11 = 647 + Math.floor(Math.random() * 25);
                                                    random12 = 687 + Math.floor(Math.random() * 25);
                                                    random13 = 727 + Math.floor(Math.random() * 25);
                                                    random14 = 767 + Math.floor(Math.random() * 25);
                                                    random15 = 207 + Math.floor(Math.random() * 25);
                                                    random16 = 167 + Math.floor(Math.random() * 25);
                                                    random17 = 807 + Math.floor(Math.random() * 25);
                                                    id = "pnlblack" + random;
                                                    id0 = "pnlblack" + random0;
                                                    id1 = "pnlblack" + random1;
                                                    id2 = "pnlblack" + random2;
                                                    id3 = "pnlblack" + random3;
                                                    id4 = "pnlblack" + random4;
                                                    id5 = "pnlblack" + random5;
                                                    id6 = "pnlblack" + random6;
                                                    id7 = "pnlblack" + random7;
                                                    id8 = "pnlblack" + random8;
                                                    id9 = "pnlblack" + random9;
                                                    id10 = "pnlblack" + random10;
                                                    id11 = "pnlblack" + random11;
                                                    id12 = "pnlblack" + random12;
                                                    id13 = "pnlblack" + random13;
                                                    id14 = "pnlblack" + random14;
                                                    id15 = "pnlblack" + random15;
                                                    id16 = "pnlblack" + random16;
                                                    id17 = "pnlblack" + random17;
                                                    document.getElementById(id).style.opacity = "0";
                                                    document.getElementById(id0).style.opacity = "0";
                                                    document.getElementById(id1).style.opacity = "0";
                                                    document.getElementById(id2).style.opacity = "0";
                                                    document.getElementById(id3).style.opacity = "0";
                                                    document.getElementById(id4).style.opacity = "0";
                                                    document.getElementById(id5).style.opacity = "0";
                                                    document.getElementById(id6).style.opacity = "0";
                                                    document.getElementById(id7).style.opacity = "0";
                                                    document.getElementById(id8).style.opacity = "0";
                                                    document.getElementById(id9).style.opacity = "0";
                                                    document.getElementById(id10).style.opacity = "0";
                                                    document.getElementById(id11).style.opacity = "0";
                                                    document.getElementById(id12).style.opacity = "0";
                                                    document.getElementById(id13).style.opacity = "0";
                                                    document.getElementById(id14).style.opacity = "0";
                                                    document.getElementById(id15).style.opacity = "0";
                                                    document.getElementById(id16).style.opacity = "0";
                                                    document.getElementById(id17).style.opacity = "0";
                                                } else {
                                                    clearInterval(carreNoir3);
                                                }
                                            }, 40);
                                            sleep(300).then(() => {
                                                grille3 = 200;
                                                var carreNoir3 = setInterval(function () {
                                                    if (grille3 >= 0) {
                                                        grille3--;
                                                        random = 324 + Math.floor(Math.random() * 33);
                                                        random0 = 364 + Math.floor(Math.random() * 33);
                                                        random1 = 644 + Math.floor(Math.random() * 33);
                                                        random2 = 684 + Math.floor(Math.random() * 33);
                                                        random3 = 404 + Math.floor(Math.random() * 33);
                                                        random4 = 444 + Math.floor(Math.random() * 33);
                                                        random5 = 484 + Math.floor(Math.random() * 33);
                                                        random6 = 524 + Math.floor(Math.random() * 33);
                                                        random7 = 564 + Math.floor(Math.random() * 33);
                                                        random8 = 604 + Math.floor(Math.random() * 33);
                                                        random9 = 284 + Math.floor(Math.random() * 33);
                                                        random10 = 244 + Math.floor(Math.random() * 33);
                                                        random11 = 644 + Math.floor(Math.random() * 33);
                                                        random12 = 684 + Math.floor(Math.random() * 33);
                                                        random13 = 724 + Math.floor(Math.random() * 33);
                                                        random14 = 764 + Math.floor(Math.random() * 33);
                                                        random15 = 204 + Math.floor(Math.random() * 33);
                                                        random16 = 164 + Math.floor(Math.random() * 33);
                                                        random17 = 804 + Math.floor(Math.random() * 33);
                                                        random18 = 844 + Math.floor(Math.random() * 33);
                                                        random19 = 124 + Math.floor(Math.random() * 33);
                                                        random20 = 84 + Math.floor(Math.random() * 33);
                                                        random21 = 884 + Math.floor(Math.random() * 33);
                                                        id = "pnlblack" + random;
                                                        id0 = "pnlblack" + random0;
                                                        id1 = "pnlblack" + random1;
                                                        id2 = "pnlblack" + random2;
                                                        id3 = "pnlblack" + random3;
                                                        id4 = "pnlblack" + random4;
                                                        id5 = "pnlblack" + random5;
                                                        id6 = "pnlblack" + random6;
                                                        id7 = "pnlblack" + random7;
                                                        id8 = "pnlblack" + random8;
                                                        id9 = "pnlblack" + random9;
                                                        id10 = "pnlblack" + random10;
                                                        id11 = "pnlblack" + random11;
                                                        id12 = "pnlblack" + random12;
                                                        id13 = "pnlblack" + random13;
                                                        id14 = "pnlblack" + random14;
                                                        id15 = "pnlblack" + random15;
                                                        id16 = "pnlblack" + random16;
                                                        id17 = "pnlblack" + random17;
                                                        id18 = "pnlblack" + random18;
                                                        id19 = "pnlblack" + random19;
                                                        id20 = "pnlblack" + random20;
                                                        id21 = "pnlblack" + random21;
                                                        document.getElementById(id).style.opacity = "0";
                                                        document.getElementById(id0).style.opacity = "0";
                                                        document.getElementById(id1).style.opacity = "0";
                                                        document.getElementById(id2).style.opacity = "0";
                                                        document.getElementById(id3).style.opacity = "0";
                                                        document.getElementById(id4).style.opacity = "0";
                                                        document.getElementById(id5).style.opacity = "0";
                                                        document.getElementById(id6).style.opacity = "0";
                                                        document.getElementById(id7).style.opacity = "0";
                                                        document.getElementById(id8).style.opacity = "0";
                                                        document.getElementById(id9).style.opacity = "0";
                                                        document.getElementById(id10).style.opacity = "0";
                                                        document.getElementById(id11).style.opacity = "0";
                                                        document.getElementById(id12).style.opacity = "0";
                                                        document.getElementById(id13).style.opacity = "0";
                                                        document.getElementById(id14).style.opacity = "0";
                                                        document.getElementById(id15).style.opacity = "0";
                                                        document.getElementById(id16).style.opacity = "0";
                                                        document.getElementById(id17).style.opacity = "0";
                                                        document.getElementById(id18).style.opacity = "0";
                                                        document.getElementById(id19).style.opacity = "0";
                                                        document.getElementById(id20).style.opacity = "0";
                                                        document.getElementById(id21).style.opacity = "0";
                                                    } else {
                                                        clearInterval(carreNoir3);
                                                    }
                                                }, 25);
                                                sleep(250).then(() => {
                                                    grille4 = 140;
                                                    var carreNoir4 = setInterval(function () {
                                                        if (grille4 >= 0) {
                                                            console.log(grille4);
                                                            grille4--;
                                                            random = 320 + Math.floor(Math.random() * 40);
                                                            random0 = 360 + Math.floor(Math.random() * 40);
                                                            random1 = 640 + Math.floor(Math.random() * 40);
                                                            random2 = 680 + Math.floor(Math.random() * 40);
                                                            random3 = 400 + Math.floor(Math.random() * 40);
                                                            random4 = 440 + Math.floor(Math.random() * 40);
                                                            random5 = 480 + Math.floor(Math.random() * 40);
                                                            random6 = 520 + Math.floor(Math.random() * 40);
                                                            random7 = 560 + Math.floor(Math.random() * 40);
                                                            random8 = 600 + Math.floor(Math.random() * 40);
                                                            random9 = 280 + Math.floor(Math.random() * 40);
                                                            random10 = 240 + Math.floor(Math.random() * 40);
                                                            random11 = 640 + Math.floor(Math.random() * 40);
                                                            random12 = 680 + Math.floor(Math.random() * 40);
                                                            random13 = 720 + Math.floor(Math.random() * 40);
                                                            random14 = 760 + Math.floor(Math.random() * 40);
                                                            random15 = 200 + Math.floor(Math.random() * 40);
                                                            random16 = 160 + Math.floor(Math.random() * 40);
                                                            random17 = 800 + Math.floor(Math.random() * 40);
                                                            random18 = 840 + Math.floor(Math.random() * 40);
                                                            random19 = 120 + Math.floor(Math.random() * 40);
                                                            random20 = 80 + Math.floor(Math.random() * 40);
                                                            random21 = 880 + Math.floor(Math.random() * 40);
                                                            random22 = 40 + Math.floor(Math.random() * 40);
                                                            random23 = Math.floor(Math.random() * 40);
                                                            random24 = 920 + Math.floor(Math.random() * 40);
                                                            random25 = 960 + Math.floor(Math.random() * 40);
                                                            id = "pnlblack" + random;
                                                            id0 = "pnlblack" + random0;
                                                            id1 = "pnlblack" + random1;
                                                            id2 = "pnlblack" + random2;
                                                            id3 = "pnlblack" + random3;
                                                            id4 = "pnlblack" + random4;
                                                            id5 = "pnlblack" + random5;
                                                            id6 = "pnlblack" + random6;
                                                            id7 = "pnlblack" + random7;
                                                            id8 = "pnlblack" + random8;
                                                            id9 = "pnlblack" + random9;
                                                            id10 = "pnlblack" + random10;
                                                            id11 = "pnlblack" + random11;
                                                            id12 = "pnlblack" + random12;
                                                            id13 = "pnlblack" + random13;
                                                            id14 = "pnlblack" + random14;
                                                            id15 = "pnlblack" + random15;
                                                            id16 = "pnlblack" + random16;
                                                            id17 = "pnlblack" + random17;
                                                            id18 = "pnlblack" + random18;
                                                            id19 = "pnlblack" + random19;
                                                            id20 = "pnlblack" + random20;
                                                            id21 = "pnlblack" + random21;
                                                            id22 = "pnlblack" + random22;
                                                            id23 = "pnlblack" + random23;
                                                            id24 = "pnlblack" + random24;
                                                            id25 = "pnlblack" + random25;
                                                            document.getElementById(id).style.opacity = "0";
                                                            document.getElementById(id0).style.opacity = "0";
                                                            document.getElementById(id1).style.opacity = "0";
                                                            document.getElementById(id2).style.opacity = "0";
                                                            document.getElementById(id3).style.opacity = "0";
                                                            document.getElementById(id4).style.opacity = "0";
                                                            document.getElementById(id5).style.opacity = "0";
                                                            document.getElementById(id6).style.opacity = "0";
                                                            document.getElementById(id7).style.opacity = "0";
                                                            document.getElementById(id8).style.opacity = "0";
                                                            document.getElementById(id9).style.opacity = "0";
                                                            document.getElementById(id10).style.opacity = "0";
                                                            document.getElementById(id11).style.opacity = "0";
                                                            document.getElementById(id12).style.opacity = "0";
                                                            document.getElementById(id13).style.opacity = "0";
                                                            document.getElementById(id14).style.opacity = "0";
                                                            document.getElementById(id15).style.opacity = "0";
                                                            document.getElementById(id16).style.opacity = "0";
                                                            document.getElementById(id17).style.opacity = "0";
                                                            document.getElementById(id18).style.opacity = "0";
                                                            document.getElementById(id19).style.opacity = "0";
                                                            document.getElementById(id20).style.opacity = "0";
                                                            document.getElementById(id21).style.opacity = "0";
                                                            document.getElementById(id22).style.opacity = "0";
                                                            document.getElementById(id23).style.opacity = "0";
                                                            document.getElementById(id24).style.opacity = "0";
                                                            document.getElementById(id25).style.opacity = "0";
                                                        } else {
                                                            clearInterval(carreNoir4);
                                                            var carres = document.getElementsByClassName("pnlblack");
                                                            for (i = 0; i < carres.length; i++) {
                                                                carres[i].style.opacity = "0";
                                                            }
                                                        }
                                                    }, 18);
                                                });
                                            });
                                        });
                                    });
                                });
                            });
                        });
                    });
                } else {
                    document.getElementById(pnl).className = classOpen;
                }
            }
        }

        function openDocument(path) {
        }
        function closeAll() {
            document.getElementById("pnlMenuOpen").className = "";
            document.getElementById("pnlmenu").firstChild.className = "outils";
            document.getElementById("pnlWindows").className = "";
            document.getElementById("pnlMenuEject").className = "";
            document.getElementById("pnlFichiers").className = "";
            document.getElementById("pnlVeille").className = "";
        }

        function tooltipOn(id) {
            id = id + "Tooltip";
            if (id === "menuTooltip" && document.getElementById("pnlmenu").firstChild.classList.contains("btnOpenMenuUSB")) {
                document.getElementById("menuTooltip").style.visibility = "hidden";
            } else if (id === "WindowsTooltip" && document.getElementById("pnlWindows").classList.contains("openMenuWindows")) {
                document.getElementById("WindowsTooltip").style.visibility = "hidden";
            } else if (id === "FichiersTooltip" && document.getElementById("pnlFichiers").classList.contains("openMenuFichiers")) {
                document.getElementById("FichiersTooltip").style.visibility = "hidden";
            } else {
                $("#" + id).css("transition-delay", "0.5s");
                $("#" + id).css("visibility", "visible");
                $("#" + id).css("opacity", "1");
                if (id == "CalendarTooltip") {
                    ladate = new Date();
                    nbJourSemaine = ladate.getDay();
                    nbMonth = ladate.getMonth();
                    switch (nbJourSemaine) {
                        case 0:
                            jourSemaine = "Dimanche";
                            break;
                        case 1:
                            jourSemaine = "Lundi";
                            break;
                        case 2:
                            jourSemaine = "Mardi";
                            break;
                        case 3:
                            jourSemaine = "Mercredi";
                            break;
                        case 4:
                            jourSemaine = "Jeudi";
                            break;
                        case 5:
                            jourSemaine = "Vendredi";
                            break;
                        case 6:
                            jourSemaine = "Samedi";
                            break;
                    }
                    switch (nbMonth) {
                        case 0:
                            month = "Janvier";
                            break;
                        case 1:
                            month = "Février";
                            break;
                        case 2:
                            month = "Mars";
                            break;
                        case 3:
                            month = "Avril";
                            break;
                        case 4:
                            month = "Mai";
                            break;
                        case 5:
                            month = "Juin";
                            break;
                        case 6:
                            month = "Juillet";
                            break;
                        case 7:
                            month = "Août";
                            break;
                        case 8:
                            month = "Septembre";
                            break;
                        case 9:
                            month = "Octobre";
                            break;
                        case 10:
                            month = "Novembre";
                            break;
                        case 11:
                            month = "Decembre";
                            break;
                    }
                    document.getElementById(id).innerHTML = jourSemaine + " " + ladate.getDate() + " " + month + " " + ladate.getFullYear();
                }
            }
        }
        function tooltipOut(id) {
            id = "#" + id + "Tooltip";
            $(id).css("transition-delay", "0s");
            $(id).css("visibility", "hidden");
            $(id).css("opacity", "0");
        }

        function arret() {
            document.getElementById("pnlFondBleu").style.display = "block";
            document.getElementById("lbArret").style.display = "block";
            document.querySelector(".loader").style.display = "block";
            sleep(2500).then(() => { window.close() });
        }
        page = 0;
        function Next(id) {
            if (id == "Veille0") {
                nb = id.substring(id.length - 1)
                document.getElementById("pnlVeillePompier" + nb).style.transition = "1s"
                document.getElementById("pnlVeillePompier" + nb).classList.add("Next")
                if (page != 0) {
                    if (document.getElementById("pnlVeille" + (page - 1) + "P" + nb).classList.contains("Milieu")) {
                        document.getElementById("pnlVeille" + page + "P" + nb).classList.add("Milieu");
                        document.getElementById("pnlVeille" + (page - 1) + "P" + nb).classList.add("Next");
                        page++;
                    }
                } else {
                    document.getElementById("pnlVeille" + page + "P" + nb).classList.add("Milieu");
                    page++;
                }
            }
            else {
                document.getElementById("pnlProjet" + id).classList.add("Next");
                if (page != 0) {
                    if (document.getElementById("pnlDocument" + (page - 1) + "P" + id).classList.contains("Milieu")) {
                        document.getElementById("pnlDocument" + page + "P" + id).classList.add("Milieu");
                        document.getElementById("pnlDocument" + (page - 1) + "P" + id).classList.add("Next");
                        page++;
                    }
                } else {
                    document.getElementById("pnlDocument" + page + "P" + id).classList.add("Milieu");
                    page++;
                }
            }
        }

        function Precedent(id) {
            if (id == "Veille0") {
                nb = id.substring(id.length - 1)
                if (page > 1) {
                    page--;
                    if (document.getElementById("pnlVeille" + page + "P" + nb).classList.contains("Milieu")) {
                        document.getElementById("pnlVeille" + page + "P" + nb).classList.remove("Milieu");
                        document.getElementById("pnlVeille" + (page - 1) + "P" + nb).classList.remove("Next");
                    }
                } else if (page == 1) {
                    page--;
                    document.getElementById("pnlVeille" + page + "P" + nb).classList.remove("Milieu");
                    document.getElementById("pnlVeillePompier" + nb).classList.remove("Next");
                    document.getElementById("pnlVeillePompier" + nb).style.transition = "0.5s"
                }
            }
            else {
                if (page > 1) {
                    page--;
                    if (document.getElementById("pnlDocument" + page + "P" + id).classList.contains("Milieu")) {
                        document.getElementById("pnlDocument" + page + "P" + id).classList.remove("Milieu");
                        document.getElementById("pnlDocument" + (page - 1) + "P" + id).classList.remove("Next");
                    }
                } else if (page == 1) {
                    page--;
                    document.getElementById("pnlDocument" + page + "P" + id).classList.remove("Milieu");
                    document.getElementById("pnlProjet" + id).classList.remove("Next");
                }
            }
        }


        function hoverNext() {
            document.getElementById("hlNext").style.opacity = "1";
        }

        document.onkeydown = function (e) {
            panels = document.getElementsByClassName("pnlProjets")
            veilles = document.getElementsByClassName("pnlVeilles")
            for (var i = 0; i < panels.length; i++) {
                if (panels[i].style.visibility == "visible") {
                    if (i < 10) {
                        id = panels[i].getAttribute("id")
                        id = id.substring(id.length - 1)
                    } else {
                        id = panels[i].getAttribute("id")
                        id = id.substring(id.length - 2)
                    }
                }
            }
            for (var i = 0; i < veilles.length; i++) {
                if (veilles[i].style.visibility == "visible") {
                    if (i < 10) {
                        id = veilles[i].getAttribute("id")
                        id = id.substring(id.length - 1)
                    } else {
                        id = panels[i].getAttribute("id")
                        id = id.substring(id.length - 2)
                    }
                }
            }
            if (document.getElementById("pnlVeillePompier0").style.visibility == "visible") {
                veille = "Veille" + id
                switch (e.keyCode) {
                    case 37:
                        Precedent(veille)
                        break;
                    case 39:
                        Next(veille)
                        break;
                }
            } else {
                switch (e.keyCode) {
                    case 37:
                        Precedent(id)
                        break;
                    case 39:
                        Next(id)
                        break;
                }
            }
        };

        function openVeille(id) {
            closeAll();
            closeProject();
            if (document.getElementById(id).style.visibility == "hidden") {
                document.getElementById(id).style.visibility = "visible";
                document.getElementById(id).style.transform = "scale(1)";
                document.getElementById(id).style.opacity = "1";
                document.getElementById(id).style.top = "0";
            } else {
                document.getElementById(id).style.visibility = "hidden";
                document.getElementById(id).style.transform = "scale(0.05)";
                document.getElementById(id).style.opacity = "0";
                document.getElementById(id).style.top = "50%";
            }
        }
    </script>


    <style>
        @font-face {
            font-family: "Computer";
            src: url("Fonts/KodeMono-VariableFont_wght.ttf");
        }

        .Next {
            transform: translateX(-100%) !important;
        }

        .Milieu {
            width: 100% !important;
            left: 0% !important;
        }

        main {
            width: 100%;
            height: 100vh;
            background-image: url("/Images/windows11_wallpaper.jpg");
            background-size: cover;
            display: grid;
            grid-template-rows: auto 5%;
        }

        .presentationProjet {
            background-color: white;
            border-radius: 12px;
            box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
            display: flex;
            flex-direction: column;
            position: absolute;
            padding: 1rem;
        }

        .sousTitre {
            font-size: 26px;
            font-weight: bold;
            text-decoration: underline;
            padding-bottom: 1rem;
        }

        .tooltip {
            font-family: 'Segoe UI Variable Text';
            user-select: none;
            font-size: 12px;
            position: absolute;
            visibility: hidden;
            opacity: 0;
            transition: visibility 0.2s, opacity 0.2s linear;
            background-color: #F0F0F0;
            border-radius: 4px;
            padding: 7px 9px;
            box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;
            z-index: 10;
        }

        #footer {
            background-color: #DEDAE9;
            border-top: 1px solid #B5B1BB;
            backdrop-filter: blur(5px);
            display: grid;
            grid-template-columns: repeat(3,33.33%);
            user-select: none;
            z-index: 100;
        }

        .visible {
            visibility: visible !important;
            opacity: 1 !important;
        }

        .applis > img {
            height: 24px;
        }

        .applis {
            width: min-content;
            height: min-content;
            padding: 36% 35% 12% 33%;
            border-radius: 15%;
            transition: 0.2s;
        }

            .applis:hover, .outils:hover {
                background-color: #f2f2f2;
            }

        .usbMenu:hover {
            background-color: #FFFFFF;
            opacity: 1;
        }

        .outils, .usbMenu {
            width: max-content;
            height: max-content;
            transition: 0.2s;
        }

        #Calendar {
            padding: 8% 10%;
            border-radius: 6px;
        }

        #WifiSoundBatterie {
            padding: 16% 8%;
            border-radius: 8%;
        }

        #pnlmenu {
            width: max-content;
            padding: 80% 65% 92% 65%;
            border-radius: 15%;
            transition: 0.2s;
        }

        .btnOpenMenuUSB {
            transform: rotate(180deg);
        }

        #windows > img, #search > img, #fichiers > img, #contact > img, #visualStudio > img {
            transition: 0.2s;
        }

        .openMenuWindows {
            top: 89.9% !important;
            z-index: 5 !important;
            transform: scale(1) !important;
        }

        .openMenuVisualStudio {
            visibility: visible !important;
        }

        .openMenuFichiers {
            top: 74.5% !important;
            transform: scale(1) !important;
            z-index: 5 !important;
        }

        .openMenuVeille {
            top: 89.9% !important;
            z-index: 5 !important;
            transform: scale(1) !important;
        }

        #hlarreter {
            padding: 4px;
            border-radius: 4px;
        }

            #hlarreter:hover {
                background-color: #e0e0e0;
            }

        #hlEject:hover {
            background-image: linear-gradient(#ededed 0 0);
            background-size: 100% 50px;
            background-repeat: no-repeat;
        }

        .btnOpenMenu {
            transform: scale(0.8);
        }

        .openMenuUSB {
            top: 88.5% !important;
            z-index: 5 !important;
        }

        .usbMenu > img {
            height: 18px;
        }

        #hlWindDef {
            padding: 20% 20% 13% 20%;
            border-radius: 10px;
            position: absolute;
            left: 12%;
            top: 16%;
        }

        #hlUSBeject {
            padding: 30% 40% 20% 50%;
            border-radius: 10px;
            display: none;
        }

        #WifiSoundBatterie, #WifiSoundBatterie > img {
            height: 16px;
        }

        #pnlmenu > img {
            height: 7px;
            width: 12px;
        }

        .loader {
            color: #ffffff;
            font-size: 70px;
            overflow: hidden;
            width: 1em;
            height: 1em;
            border-radius: 50%;
            top: 40%;
            justify-self: center;
            transform: translateZ(0);
            animation: mltShdSpin 1.7s infinite ease, round 1.7s infinite ease;
        }

        #hlprojet1:hover, #hlprojet2:hover, #hlprojet3:hover,#hlprojet4:hover,#hlprojet5:hover,#hlprojet6:hover,#hlprojet7:hover,#hlprojet8:hover, #hlVeille:hover {
            background-color: #e6e6e6;
        }

        #hlProjet1Img > img {
            height: 100%;
            width: 100%;
        }

        #pnlFichiers > a {
            text-decoration: none;
            color: black;
        }

        #hlNext:hover, #hlPrecedent:hover {
            opacity: 1 !important;
        }

        #hlNext, #hlPrecedent {
            position: fixed;
            z-index: 10;
            opacity: 0;
            transition: 0.3s;
            background-color: #e0e0e0;
            font-size: 32px;
            text-decoration: none;
            user-select: none;
            align-self: center;
            display: none;
        }

        @keyframes mltShdSpin {
            0% {
                box-shadow: 0 -0.83em 0 -0.4em, 0 -0.83em 0 -0.42em, 0 -0.83em 0 -0.44em, 0 -0.83em 0 -0.46em, 0 -0.83em 0 -0.477em;
            }

            5%, 95% {
                box-shadow: 0 -0.83em 0 -0.4em, 0 -0.83em 0 -0.42em, 0 -0.83em 0 -0.44em, 0 -0.83em 0 -0.46em, 0 -0.83em 0 -0.477em;
            }

            10%, 59% {
                box-shadow: 0 -0.83em 0 -0.4em, -0.087em -0.825em 0 -0.42em, -0.173em -0.812em 0 -0.44em, -0.256em -0.789em 0 -0.46em, -0.297em -0.775em 0 -0.477em;
            }

            20% {
                box-shadow: 0 -0.83em 0 -0.4em, -0.338em -0.758em 0 -0.42em, -0.555em -0.617em 0 -0.44em, -0.671em -0.488em 0 -0.46em, -0.749em -0.34em 0 -0.477em;
            }

            38% {
                box-shadow: 0 -0.83em 0 -0.4em, -0.377em -0.74em 0 -0.42em, -0.645em -0.522em 0 -0.44em, -0.775em -0.297em 0 -0.46em, -0.82em -0.09em 0 -0.477em;
            }

            100% {
                box-shadow: 0 -0.83em 0 -0.4em, 0 -0.83em 0 -0.42em, 0 -0.83em 0 -0.44em, 0 -0.83em 0 -0.46em, 0 -0.83em 0 -0.477em;
            }
        }

        @keyframes round {
            0% {
                transform: rotate(0deg)
            }

            100% {
                transform: rotate(360deg)
            }
        }

        .imageProjet {
            position: absolute;
            background-size: contain;
            background-repeat: no-repeat;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server" ClientIDMode="Static">
    <main id="main" runat="server">
        <div runat="server" id="content" onclick="javascript:closeAll();" style="position: relative; display: grid;"></div>
        <footer id="footer" runat="server">
        </footer>
    </main>
</asp:Content>
