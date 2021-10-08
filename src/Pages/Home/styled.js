import styled from "styled-components";

const Conteudo = styled.div`

    background-image: url("../assets/images/photo-monza-italy-f1-wallpaper-2008-3.jpg");
    background-repeat: no-repeat;
    background-position: 110%;
    background-size: 80%;

    display: flex;
    flex-direction: row;

    .container{
        width: 30%;
        height: 100vh;
        margin: 0px;
        padding-top: 10px;
        background-color: #343434;
    }

    h1{
        font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
        font-weight: 500;

        color: white;

        text-align: center;
        padding-bottom: 30px;
    }


    .buttons{
        padding: 0px 1.5em;
    }
    .buttons button{
        font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
        font-weight: 600;

        color: white;

        background-color: #2b2b2b;
        border:none;
        padding: 1.5em;
        width: 100%;

        border-left: 4px solid white;
        transition:0.3s;
    }

    .buttons button:hover{
        color: black;
        background-color: white;
        padding: 1.7em;
    }

    
    .buttons2{
        padding: 0px 1.5em;
    }
    .buttons2 button{
        font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
        font-weight: 600;

        color: white;

        background-color: #2b2b2b;
        border:none;
        padding: 1.5em;
        width: 100%;

        border-left: 4px solid #0F8FC4;
        transition:0.3s;
    }

    .buttons2 button:hover{
        color: #0F8FC4;
        background-color: white;

        border-left: 4px solid white;
        padding: 1.7em;
    }

    .products{
        padding-left: 4em;
        padding-top: 2em;
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;

        color: white;
    }
`
export default Conteudo