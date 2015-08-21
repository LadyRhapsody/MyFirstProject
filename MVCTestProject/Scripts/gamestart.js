window.onload =  function Main() {

    var mainCanvas;

    //init
    mainCanvas = document.createElement("canvas");
    mainCanvas.style.backgroundColor = "#333";
    mainCanvas.width = 600;
    mainCanvas.height = 600;
    
    var body = document.getElementById("gameView");
    body.appendChild(mainCanvas);
}