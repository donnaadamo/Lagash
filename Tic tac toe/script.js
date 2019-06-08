$(function() {
    let cuadros = $(".cuadros");

    const X_TURN_ELEMENT = '<p id="turn">X</p>';
    const O_TURN_ELEMENT = '<p id="turn">O</p>';
    const O_TURN_MESSAGE = "It's O's turn.";
    const X_TURN_MESSAGE = "It's X's turn.";
    
    let isXTurn = true;
    let winning = false;

    cuadros.click(event => {
        if ($(event.currentTarget).children().length > 0) {
            alert("You've already clicked here!");
        }else{
            if (isXTurn){
                $(event.currentTarget).append(X_TURN_ELEMENT);
                $('#turno').text(O_TURN_MESSAGE);
                isXTurn = false;
            }else{
                $(event.currentTarget).append(O_TURN_ELEMENT);
                $('#turno').text(X_TURN_MESSAGE);
                isXTurn = true;
            }
        }

        if (
            $("#one").text() === $("#two").text() && 
            $("#two").text() === $("#three").text() && 
            $("#one").text() !== ""
        ){
            won("#one");
        }else if(
            $("#four").text() === $("#five").text() && 
            $("#five").text() === $("#six").text() &&
            $("#four").text() !== ""
        ){
            won("#four");
        }else if(
            $("#seven").text() === $("#eight").text() && 
            $("#eight").text() === $("#nine").text() && 
            $("#seven").text() !== ""
        ){
            won("#seven");
        }else if(
            $("#one").text() === $("#four").text() && 
            $("#four").text() === $("#seven").text() && 
            $("#one").text() !== ""
        ){
            won("#one");
        }else if(
            $("#three").text() === $("#six").text() && 
            $("#six").text() === $("#nine").text() && 
            $("#three").text() !== ""
        ){
            won("#three");
        }else if(
            $("#two").text() === $("#five").text() && 
            $("#five").text() === $("#eight").text() && 
            $("#two").text() !== ""
        ){
            won("#two");
        }else if(
            $("#one").text() === $("#five").text() && 
            $("#five").text() === $("#nine").text() && 
            $("#one").text() !== ""
        ){
            won("#one");
        }else if(
            $("#three").text() === $("#five").text() && 
            $("#five").text() === $("#seven").text() && 
            $("#three").text() !== ""
        ){
            won("#three");
        }

        if (
            $("#one").children().length > 0 && 
            $("#two").children().length > 0 && 
            $("#three").children().length > 0 && 
            $("#four").children().length > 0 && 
            $("#five").children().length > 0 && 
            $("#six").children().length > 0 && 
            $("#seven").children().length > 0 && 
            $("#eight").children().length > 0 && 
            $("#nine").children().length > 0 && 
            !winning
        ){
            alert("Nobody has won!");
            setTimeout(() => location.reload(), 200);
        }
    });

    function won(winner){
        winning = true;
        alert($(winner).text() + " has won!");
        setTimeout(() => location.reload(), 200);
    }
});

