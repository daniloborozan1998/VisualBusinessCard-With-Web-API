document.getElementById('btn_convert').onclick = function () {
     if ($(document.getElementById("invoice")).is(":visible")) {

        html2canvas(document.getElementById("invoice"),
            {
                allowTaint: true,
                useCORS: true
            }).then(function (canvas) {
            var anchorTag = document.createElement("a");
            document.body.appendChild(anchorTag);
            document.getElementById("previewImg").appendChild(canvas);
            anchorTag.download = "card.png";
            anchorTag.href = canvas.toDataURL();
            anchorTag.target = '_blank';
            anchorTag.click();
        });
    }

    
}