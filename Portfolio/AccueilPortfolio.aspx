<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="AccueilPortfolio.aspx.cs" Inherits="Portfolio.AccueilPortfolio" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContent" runat="server">
  <script type="text/javascript">

    var display = 12;
    var clignot1 = 60 + Math.random() * 60;
    var clignot2 = 0;

    function sleep(ms) {
      return new Promise(resolve => setTimeout(resolve, ms));
    }

    function downloadURI(uri, name) {
      var link = document.createElement("a");
      link.download = name;
      link.href = uri;
      document.body.appendChild(link);
      link.click();
      document.body.removeChild(link);
      delete link;
      sleep(2000).then(() => { unplug() });
    }

    setInterval(function () {
      clignot1--;
      clignot2--;
      if (clignot1 <= 0) {
        if (60 + Math.random() * 60 >= 105) {
          document.getElementById("rondLumiere").style.display = "none";
          sleep(500).then(() => {
            document.getElementById("rondLumiere").style.display = "block";
            sleep(60).then(() => {
              document.getElementById("rondLumiere").style.display = "none";
              sleep(60).then(() => {
                document.getElementById("rondLumiere").style.display = "block";
                sleep(40).then(() => {
                  document.getElementById("rondLumiere").style.display = "none";
                  sleep(40).then(() => {
                    document.getElementById("rondLumiere").style.display = "block";
                    sleep(20).then(() => {
                      document.getElementById("rondLumiere").style.display = "none";
                      sleep(20).then(() => {
                        document.getElementById("rondLumiere").style.display = "block";
                        sleep(10).then(() => {
                          document.getElementById("rondLumiere").style.display = "none";
                          sleep(500).then(() => {
                            document.getElementById("rondLumiere").style.display = "block";
                          });
                        });
                      });
                    });
                  });
                });
              });
            });
          });
          clignot1 = 60 + Math.random() * 60;
        } else {
          document.getElementById("rondLumiere").style.display = "none";
          sleep(200 + Math.random() * 300).then(() => {
            document.getElementById("rondLumiere").style.display = "block";
            sleep(60).then(() => {
              if (clignot2 % 2 == 0) {
                document.getElementById("rondLumiere").style.display = "none";
                sleep(10 + Math.random() * 100).then(() => {
                  document.getElementById("rondLumiere").style.display = "block";
                  if (Math.floor(Math.random() * 3) % 2 == 0) {
                    sleep(60).then(() => {
                      document.getElementById("rondLumiere").style.display = "none";
                      sleep(20).then(() => { document.getElementById("rondLumiere").style.display = "block"; });
                    });
                  }
                });
              }
            });
          });
          clignot1 = 60 + Math.random() * 60;
        }
      }
    }, 100);

    function chooseUSBrouge() {
      if (document.getElementById("USBverte").className || document.getElementById("USBviolet").className) {
        unplug();
        sleep(1300).then(() => {
          chooseUSBrouge();
        });
      } else {
        document.getElementById("USBrouge").className = "backgroundFade";
        sleep(200).then(() => {
          document.getElementById("USBrouge").className = "backgroundFade red plugged";
          document.getElementById("hlUsbRouge").removeAttribute("href");
          document.getElementById("hlUnplug").setAttribute("href", "javascript:unplug();");
          document.getElementById("lbUSBRouge").classList.add("lbUSBMove");
          sleep(1000).then(() => { document.getElementById("hlScreenProjet1").style.display = "block"; });
        });
      }
    }

    function chooseUSBverte() {
      if (document.getElementById("USBrouge").className || document.getElementById("USBviolet").className) {
        unplug();
        sleep(1300).then(() => { chooseUSBverte() });
      } else {
        document.getElementById("USBverte").className = "backgroundFade";
        sleep(200).then(() => {
          document.getElementById("USBverte").className = "backgroundFade black plugged";
          document.getElementById("hlUsbVerte").removeAttribute("href");
          document.getElementById("hlUnplug").setAttribute("href", "javascript:unplug();");
          document.getElementById("lbUSBVerte").classList.add("lbUSBMove");
          sleep(1000).then(() => { document.getElementById("hlScreenProjet2").style.display = "block"; });
        });
      }
    }

    function chooseUSBviolet() {
      if (document.getElementById("USBverte").className || document.getElementById("USBrouge").className) {
        unplug();
        sleep(1300).then(() => { chooseUSBviolet() });
      } else {
        document.getElementById("USBviolet").className = "backgroundFade";
        sleep(200).then(() => {
          document.getElementById("USBviolet").className = "backgroundFade purple plugged";
          document.getElementById("hlUsbViolet").removeAttribute("href");
          document.getElementById("hlUnplug").setAttribute("href", "javascript:unplug();");
          document.getElementById("lbUSBViolet").classList.add("lbUSBMove");
          sleep(1000).then(() => { document.getElementById("hlScreenProjet3").style.display = "block"; });
        });
      }
    }

    function unplug() {
      document.getElementById("USBviolet").classList.remove("purple");
      document.getElementById("USBrouge").classList.remove("red");
      document.getElementById("USBverte").classList.remove("black");
      document.getElementById("hlUnplug").removeAttribute("href");
      document.getElementById("hlUsbRouge").setAttribute("href", "javascript:chooseUSBrouge();");
      document.getElementById("hlUsbVerte").setAttribute("href", "javascript:chooseUSBverte();");
      document.getElementById("hlUsbViolet").setAttribute("href", "javascript:chooseUSBviolet();");
      document.getElementById("hlScreenProjet1").style.display = "none";
      document.getElementById("hlScreenProjet2").style.display = "none";
      document.getElementById("hlScreenProjet3").style.display = "none";
      document.getElementById("lbUSBRouge").classList.remove("lbUSBMove");
      document.getElementById("lbUSBVerte").classList.remove("lbUSBMove");
      document.getElementById("lbUSBViolet").classList.remove("lbUSBMove");
      sleep(1200).then(() => {
        document.getElementById("USBrouge").className = "";
        document.getElementById("USBverte").className = "";
        document.getElementById("USBviolet").className = "";
      });
    }
    on = true;

    var lbUSB = document.getElementsByClassName("lbUSB")

    function switchOn() {
      if (on) {
        actif = true;
        zob = false;
        transiSpeed = 1.5;
        document.getElementById("pnlTable").style.transition = "1.5s";
        document.getElementById("pnlTable").style.boxShadow = "rgba(255, 255, 255, 0.56) 0px 0px 26px 20px";
        document.getElementById("pnlTable").style.background = "white";
        document.getElementById("lbPortfolio").style.background = "black";
        document.getElementById("lbPortfolio").style.color = "white";
        document.getElementById("lbFooter").style.backgroundColor = "black";
        document.getElementById("lbFooter").style.color = "white";
        document.getElementById("pnlEtiquette").style.backgroundColor = "rgb(0, 0, 0)";
        document.getElementById("pnlEtiquette").style.transition = "1.5s";
        document.getElementById("pnlEtiquette").style.color = "white";
        document.getElementById("main").style.background = "rgb(0, 0, 0)";
        document.getElementById("rondNoir").style.transition = "2s";
        document.getElementById("rondNoir").style.top = "-100%";
        document.getElementById("rondLumiere").style.display = "block";
        document.getElementById("rondLumiere").style.zIndex = "-1";
        sleep(500).then(() => {
          document.getElementById("rondLumiere").style.zIndex = "-1";
        })
        for (i = 0; i < lbUSB.length; i++) {
          lbUSB[i].style.backgroundColor = "black";
          lbUSB[i].style.color = "white";
        }
        on = false;
      }
      else {
        actif = false;
        document.getElementById("pnlTable").style.boxShadow = "8px 8px 20px #292828";
        document.getElementById("rondNoir").style.transition = "1s";
        document.getElementById("lbPortfolio").style.background = "transparent";
        document.getElementById("lbPortfolio").style.color = "black";
        document.getElementById("lbFooter").style.backgroundColor = "transparent";
        document.getElementById("lbFooter").style.color = "black";
        document.getElementById("pnlTable").style.background = "linear-gradient(to top left, rgb(83, 49, 0), white 450%)";
        document.getElementById("pnlEtiquette").style.backgroundColor = "white";
        document.getElementById("pnlEtiquette").style.color = "black";
        document.getElementById("main").style.background = "linear-gradient(to top left, rgb(100, 100, 100), white 180%)";
        document.getElementById("rondNoir").style.top = "-7%";
        document.getElementById("rgb").style.backgroundColor = "rgb(255, 255, 255)";
        for (i = 0; i < lbUSB.length; i++) {
          lbUSB[i].style.backgroundColor = "white";
          lbUSB[i].style.color = "black";
        }
        sleep(2000).then(() => {
          document.getElementById("rondLumiere").style.zIndex = "6";
        })
        on = true;
      }
    }

    function changeColor(couleur) {
      if (on) {
        alert("Veuillez allumer les LED");
      } else {
        actif = false;
        sleep(2000).then(() => {
          actif = true;
        });
        zob = false;
        switch (couleur) {
          case 1:
            document.getElementById("pnlTable").style.boxShadow = "rgba(255, 255, 255, 0.56) 0px 0px 50px 15px";
            document.getElementById("pnlEtiquette").style.color = "rgb(255, 255, 255)";
            document.getElementById("rgb").style.backgroundColor = "rgb(255, 255, 255)";
            document.getElementById("lbPortfolio").style.color = "white";
            document.getElementById("lbFooter").style.color = "white";
            for (i = 0; i < lbUSB.length; i++) {
              lbUSB[i].style.color = "white";
            }
            break;
          case 2:
            document.getElementById("pnlTable").style.boxShadow = "rgba(255, 0, 0, 0.56) 0px 0px 50px 18px, inset rgba(255, 0, 0, 0.45) 0px 0px 50px 1px";
            document.getElementById("pnlEtiquette").style.color = "rgb(255, 0, 0)";
            document.getElementById("rgb").style.backgroundColor = "rgb(255, 0, 0)";
            document.getElementById("lbPortfolio").style.color = "rgb(255, 0, 0)";
            document.getElementById("lbFooter").style.color = "rgb(255, 0, 0)";
            for (i = 0; i < lbUSB.length; i++) {
              lbUSB[i].style.color = "rgb(255, 0, 0)";
            }
            break;
          case 3:
            document.getElementById("pnlTable").style.boxShadow = "rgba(0, 255, 0, 0.56) 0px 0px 50px 18px, inset rgba(0, 255, 0, 0.56) 0px 0px 50px 1px";
            document.getElementById("pnlEtiquette").style.color = "rgb(0, 255, 0)";
            document.getElementById("rgb").style.backgroundColor = "rgb(0, 255, 0)";
            document.getElementById("lbPortfolio").style.color = "rgb(0, 255, 0)";
            document.getElementById("lbFooter").style.color = "rgb(0, 255, 0)";
            for (i = 0; i < lbUSB.length; i++) {
              lbUSB[i].style.color = "rgb(0, 255, 0)";
            }
            break;
          case 4:
            document.getElementById("pnlTable").style.boxShadow = "rgba(0, 0, 255, 0.56) 0px 0px 50px 18px, inset rgba(0, 0, 255, 0.56) 0px 0px 50px 1px";
            document.getElementById("pnlEtiquette").style.color = "rgb(0, 0, 255)";
            document.getElementById("rgb").style.backgroundColor = "rgb(0, 0, 255)";
            document.getElementById("lbPortfolio").style.color = "rgb(0, 0, 255)";
            document.getElementById("lbFooter").style.color = "rgb(0, 0, 255)";
            for (i = 0; i < lbUSB.length; i++) {
              lbUSB[i].style.color = "rgb(0, 0, 255)";
            }
            break;
          case 5:
            document.getElementById("pnlTable").style.boxShadow = "rgba(255, 255, 0, 0.56) 0px 0px 50px 18px, inset rgba(255, 255, 0, 0.56) 0px 0px 50px 1px";
            document.getElementById("pnlEtiquette").style.color = "yellow";
            document.getElementById("rgb").style.backgroundColor = "yellow";
            document.getElementById("lbPortfolio").style.color = "yellow";
            document.getElementById("lbFooter").style.color = "yellow";
            for (i = 0; i < lbUSB.length; i++) {
              lbUSB[i].style.color = "yellow";
            }
            break;
          case 6:
            document.getElementById("pnlTable").style.boxShadow = "rgba(0, 255, 255,0.56) 0px 0px 50px 18px, inset rgba(0, 255, 255,0.56) 0px 0px 50px 1px";
            document.getElementById("pnlEtiquette").style.color = "cyan";
            document.getElementById("rgb").style.backgroundColor = "cyan";
            document.getElementById("lbPortfolio").style.color = "cyan";
            document.getElementById("lbFooter").style.color = "cyan";
            for (i = 0; i < lbUSB.length; i++) {
              lbUSB[i].style.color = "cyan";
            }
            break;
          case 7:
            document.getElementById("pnlTable").style.boxShadow = "rgba(200, 0, 255,0.56) 0px 0px 50px 18px, inset rgba(200, 0, 255,0.56) 0px 0px 50px 1px";
            document.getElementById("pnlEtiquette").style.color = "rgb(200, 0, 255)";
            document.getElementById("rgb").style.backgroundColor = "rgb(200, 0, 255)";
            document.getElementById("lbPortfolio").style.color = "rgb(200, 0, 255)";
            document.getElementById("lbFooter").style.color = "rgb(200, 0, 255)";
            for (i = 0; i < lbUSB.length; i++) {
              lbUSB[i].style.color = "rgb(200, 0, 255)";
            }
            break;
        }
        on = false;
      }
    }

    function raimbow() {
      if (on) {
        alert("Veuillez allumer les LED");
      } else {
        i = 0
        speed = 1400;
        if (zob) {
          zob = false;
        } else {
          zob = true;
          document.getElementById("pnlTable").style.boxShadow = "rgba(200, 0, 255,0.56) 0px 0px 50px 18px, inset rgba(200, 0, 255,0.56) 0px 0px 50px 1px";
          document.getElementById("pnlEtiquette").style.color = "rgb(200, 0, 255)";
          document.getElementById("rgb").style.backgroundColor = "rgb(200, 0, 255)";
          document.getElementById("lbPortfolio").style.color = "rgb(200, 0, 255)";
          document.getElementById("lbFooter").style.color = "rgb(200, 0, 255)";
        }
        transiSpeed = 1.5;
        document.getElementById("pnlTable").style.transition = transiSpeed + "s";
        document.getElementById("pnlEtiquette").style.transition = transiSpeed + "s";
        document.getElementById("rgb").style.transition = transiSpeed + "s";
        document.getElementById("lbPortfolio").style.transition = transiSpeed + "s";
        document.getElementById("lbFooter").style.transition = transiSpeed + "s";
        for (j = 0; j < lbUSB.length; j++) {
          lbUSB[j].style.transition = "color " + transiSpeed + "s, top 0.8s, left 0.8s";
        }
        for (j = 0; j < lbUSB.length; j++) {
          lbUSB[j].style.color = "rgb(200, 0, 255)";
        }
        var interval = setInterval(function () {
          if (!actif || !zob) {
            clearInterval(interval);
          } else {
            i++;
            switch (i) {
              case 1:
                document.getElementById("pnlTable").style.boxShadow = "rgba(255, 255, 255, 0.56) 0px 0px 50px 15px";
                document.getElementById("pnlEtiquette").style.color = "rgb(255, 255, 255)";
                document.getElementById("rgb").style.backgroundColor = "rgb(255, 255, 255)";
                document.getElementById("lbPortfolio").style.color = "white";
                document.getElementById("lbFooter").style.color = "white";
                for (j = 0; j < lbUSB.length; j++) {
                  lbUSB[j].style.color = "white";
                }
                break;
              case 2:
                document.getElementById("pnlTable").style.boxShadow = "rgba(255, 0, 0, 0.56) 0px 0px 50px 18px, inset rgba(255, 0, 0, 0.45) 0px 0px 50px 1px";
                document.getElementById("pnlEtiquette").style.color = "rgb(255, 0, 0)";
                document.getElementById("rgb").style.backgroundColor = "rgb(255, 0, 0)";
                document.getElementById("lbPortfolio").style.color = "rgb(255, 0, 0)";
                document.getElementById("lbFooter").style.color = "rgb(255, 0, 0)";
                for (j = 0; j < lbUSB.length; j++) {
                  lbUSB[j].style.color = "rgb(255, 0, 0)";
                }
                break;
              case 3:
                document.getElementById("pnlTable").style.boxShadow = "rgba(0, 255, 0, 0.56) 0px 0px 50px 18px, inset rgba(0, 255, 0, 0.56) 0px 0px 50px 1px";
                document.getElementById("pnlEtiquette").style.color = "rgb(0, 255, 0)";
                document.getElementById("rgb").style.backgroundColor = "rgb(0, 255, 0)";
                document.getElementById("lbPortfolio").style.color = "rgb(0, 255, 0)";
                document.getElementById("lbFooter").style.color = "rgb(0, 255, 0)";
                for (j = 0; j < lbUSB.length; j++) {
                  lbUSB[j].style.color = "rgb(0, 255, 0)";
                }
                break;
              case 4:
                document.getElementById("pnlTable").style.boxShadow = "rgba(0, 0, 255, 0.56) 0px 0px 50px 18px, inset rgba(0, 0, 255, 0.56) 0px 0px 50px 1px";
                document.getElementById("pnlEtiquette").style.color = "rgb(0, 0, 255)";
                document.getElementById("rgb").style.backgroundColor = "rgb(0, 0, 255)";
                document.getElementById("lbPortfolio").style.color = "rgb(0, 0, 255)";
                document.getElementById("lbFooter").style.color = "rgb(0, 0, 255)";
                for (j = 0; j < lbUSB.length; j++) {
                  lbUSB[j].style.color = "rgb(0, 0, 255)";
                }
                break;
              case 5:
                document.getElementById("pnlTable").style.boxShadow = "rgba(255, 255, 0, 0.56) 0px 0px 50px 18px, inset rgba(255, 255, 0, 0.56) 0px 0px 50px 1px";
                document.getElementById("pnlEtiquette").style.color = "yellow";
                document.getElementById("rgb").style.backgroundColor = "yellow";
                document.getElementById("lbPortfolio").style.color = "yellow";
                document.getElementById("lbFooter").style.color = "yellow";
                for (j = 0; j < lbUSB.length; j++) {
                  lbUSB[j].style.color = "yellow";
                }
                break;
              case 6:
                document.getElementById("pnlTable").style.boxShadow = "rgba(0, 255, 255,0.56) 0px 0px 50px 18px, inset rgba(0, 255, 255,0.56) 0px 0px 50px 1px";
                document.getElementById("pnlEtiquette").style.color = "cyan";
                document.getElementById("rgb").style.backgroundColor = "cyan";
                document.getElementById("lbPortfolio").style.color = "cyan";
                document.getElementById("lbFooter").style.color = "cyan";
                for (j = 0; j < lbUSB.length; j++) {
                  lbUSB[j].style.color = "cyan";
                }
                break;
              case 7:
                document.getElementById("pnlTable").style.boxShadow = "rgba(200, 0, 255,0.56) 0px 0px 50px 18px, inset rgba(200, 0, 255,0.56) 0px 0px 50px 1px";
                document.getElementById("pnlEtiquette").style.color = "rgb(200, 0, 255)";
                document.getElementById("rgb").style.backgroundColor = "rgb(200, 0, 255)";
                document.getElementById("lbPortfolio").style.color = "rgb(200, 0, 255)";
                document.getElementById("lbFooter").style.color = "rgb(200, 0, 255)";
                for (j = 0; j < lbUSB.length; j++) {
                  lbUSB[j].style.color = "rgb(200, 0, 255)";
                }
                break;
            }
          }
          if (i == 7)
            i = 0
        }, speed);
      }
    }

    function speedUp() {
      if (transiSpeed <= 0.1) {
        transiSpeed = 0.1;
      } else {
        transiSpeed -= 0.2;
      }
      speed -= 200;
      document.getElementById("pnlTable").style.transition = transiSpeed + "s";
      document.getElementById("pnlEtiquette").style.transition = transiSpeed + "s";
      document.getElementById("rgb").style.transition = transiSpeed + "s";
      document.getElementById("lbPortfolio").style.transition = transiSpeed + "s";
      document.getElementById("lbFooter").style.transition = transiSpeed + "s";
      for (j = 0; j < lbUSB.length; j++) {
        lbUSB[j].style.transition = transiSpeed + "s";
      }
    }

    function speedDown() {
      if (transiSpeed >= 6.1) {
        transiSpeed = 6.1;
      } else {
        transiSpeed += 0.2;
      }
      speed += 200;
      document.getElementById("pnlTable").style.transition = transiSpeed + "s";
      document.getElementById("pnlEtiquette").style.transition = transiSpeed + "s";
      document.getElementById("rgb").style.transition = transiSpeed + "s";
      document.getElementById("lbPortfolio").style.transition = transiSpeed + "s";
      document.getElementById("lbFooter").style.transition = transiSpeed + "s";
      for (j = 0; j < lbUSB.length; j++) {
        lbUSB[j].style.transition = transiSpeed + "s";
      }
    }

  </script>
  <style>
    @font-face {
      font-family: "Computer";
      src: url("Fonts/KodeMono-VariableFont_wght.ttf");
    }

    main {
      width: 100%;
      height: 100vh;
      justify-content: center;
      align-items: center;
      display: flex;
      background: linear-gradient(to top left, rgb(100, 100, 100), white 180%);
      font-family: "Computer";
    }

    #pnlTable {
      display: grid;
      width: 95%;
      height: 90%;
      background: linear-gradient(to top left, rgb(83, 49, 0), white 450%);
      grid-template-columns: 40% 25% 35%;
      border: 1px solid black;
      box-shadow: 8px 8px 20px #292828;
      position: absolute;
    }

    #divPaper {
      display: grid;
      grid-template-rows: 23% auto 24px;
    }

    #pnlEtiquette {
      background-color: white;
      height: fit-content;
      margin: 2% 2% 0 0;
      padding: 0 3% 3%;
      justify-self: flex-end;
      border-radius: 12px;
      display: grid;
      grid-template-rows: 50px auto;
      border: 1px solid black;
    }

    #divPc {
      display: flex;
      justify-content: center;
      z-index: 15;
    }

    #divMiddle {
      display: grid;
      grid-template-rows: auto;
    }

    #pnlPortfolio {
      display: grid;
      justify-content: center;
      text-align: center;
      width: 100%;
      height: 100%;
      grid-template-rows: auto auto auto;
    }

    #lbFooter {
      text-align: right;
      font-weight: bold;
      padding-right: 5px;
      color: black;
      grid-row-start: 3;
    }

    #USBrouge, #USBverte, #USBviolet {
      position: relative;
      left: 0;
      top: 0;
      justify-self: center;
      padding: 4%;
      margin: 7%;
      border-radius: 0 3rem 3rem 0;
      transition: background-color 0.2s, left 0.8s, top 0.8s;
      filter: drop-shadow(2px 2px 4px black);
    }

    #USBrouge {
      background-image: linear-gradient(to right, rgba(255,255,255,0) 15%,darkred 85%);
    }

    #USBverte {
      background-image: linear-gradient(to right, rgba(255,255,255,0) 15%,darkgreen 85%);
    }

    #USBviolet {
      background-image: linear-gradient(to right, rgba(255,255,255,0) 15%,purple 85%);
    }

    #hlUsbRouge, #hlUsbVerte, #hlUsbViolet {
      position: absolute;
      z-index: 10;
      width: 43%;
      height: 12%;
    }

    .red {
      top: 19.5% !important;
      left: -51.5% !important;
      z-index: 0;
    }

    .black {
      top: -80.8% !important;
      left: -51.5% !important;
      z-index: 0;
    }

    .purple {
      top: -182.5% !important;
      left: -51.5% !important;
      z-index: 0;
    }

    .plugged {
      background-image: none !important;
    }

    .backgroundFade {
      background-color: rgba(40,27,10,0) !important;
    }

    main > div > div {
      height: 89.7vh;
    }

    #imgStylos {
      margin-top: 1rem;
      height: 90%;
    }

    #rondLumiere {
      position: fixed;
      width: 85%;
      opacity: 0.5;
      background-image: radial-gradient(rgb(255,229,200) 9%,#FDC974 15%,rgba(255,255,255,0)67%);
      top: -78%;
      left: 24%;
      z-index: 6;
    }

    #rondNoir {
      position: fixed;
      background-image: radial-gradient(rgb(60,60,60) 18%,black 58%,rgba(255,229,200,0.5) 62%,rgba(255,255,255,0)67%);
      width: 10%;
      height: 34%;
      top: -7%;
      left: 61%;
      z-index: 6;
    }

    #hlScreenProjet1 > img, #hlScreenProjet2 > img, #hlScreenProjet3 > img, #hlScreenDefault > img {
      width: 100%;
      height: 100%;
    }

    .hlScreen {
      position: absolute;
      width: 30.2%;
      height: 42%;
      display: none;
      top: 2.4%;
    }

    .lbUSB {
      position: absolute;
      background-color: white;
      padding: 4px;
      font-weight: 600;
      font-size: 14px;
      border-radius: 4px;
      z-index: 5;
      transition: 0.8s;
    }

    #lbUSBRouge {
      top: 30.1%;
      left: 37.2%;
    }

    #lbUSBVerte {
      top: 57.2%;
      left: 44%;
    }

    #lbUSBViolet {
      top: 84.2%;
      left: 45%;
    }


    .lbUSBMove {
      top: 35.3% !important;
      left: 0.5% !important;
    }

    @media (max-width: 1500px) {
      #pnlTable {
        display: none;
      }

      #ecranPcPetit {
        display: block !important;
        font-weight: bold;
        font-size: 2.5vw;
      }
    }

    @media (min-height : 960px) {
      .red {
        top: 11.5% !important;
        left: -48.5% !important;
      }

      .black {
        top: -89% !important;
        left: -48.5% !important;
      }

      .purple {
        top: -190.5% !important;
        left: -48.5% !important;
      }

      .lbUSBMove {
        top: 34.7% !important;
        left: 3.3% !important;
      }

      #hlUnplug {
        top: 31.5% !important;
        left: -14.5% !important;
      }

      #hlUsbRouge {
        top: 28% !important;
      }

      #hlUsbVerte {
        top: 55% !important;
      }

      #hlUsbViolet {
        top: 81% !important;
      }

      #lbUSBRouge {
        top: 31.7%;
      }

      #lbUSBVerte {
        top: 58.2%;
      }

      #lbUSBViolet {
        top: 84.5%;
      }

      .hlScreen {
        width: 31.7%;
      }

      #hlScreenDefault {
        width: 31.7%;
      }

      .lbUSBMove {
        top: 34.7% !important;
        left: 3.3% !important;
      }
    }
  </style>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" ClientIDMode="Static">
  <main runat="server" id="main">
    <asp:Panel runat="server" ID="pnlTable">
      <div runat="server" id="divPc"></div>

      <div runat="server" id="divMiddle" style="position: relative;">
        <asp:Panel runat="server" ID="pnlPortfolio"></asp:Panel>
      </div>

      <div runat="server" id="divPaper"></div>
    </asp:Panel>
  </main>

</asp:Content>
