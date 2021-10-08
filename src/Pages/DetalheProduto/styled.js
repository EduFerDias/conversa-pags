import styled from "styled-components";

const Conteudo = styled.div`
background-color: #343434;
display: flex;
flex-direction: row;
font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
font-weight: 600;
color: white;
height: 94.7vh;
padding: 20px 4em;


.b2{
    display: flex;
    flex-direction: column;
    justify-content: center;
    padding-left: 10%;
    height: 80%;
    width: max-content;
}
.b2 div button{
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
    font-weight: 600;

    border: none;
    border-radius: 10px;

    background-color: #2b2b2b;
    color: white;

    margin-top: 1em;
    padding: 1.5em;
    width: 100%;
}
img{
    width: 550px;
}
.t1{
    padding-top: 30px;
}

a{
    color: white;
    background-image: linear-gradient( to left bottom, black, gray);
    margin: 1em;
    padding: 1em;
    text-align: center;
    transition: 1s;
}
a:hover{
    color: black;
    background-image: linear-gradient( to left bottom, white, gray);
}

`

export default Conteudo