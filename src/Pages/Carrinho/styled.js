import styled from "styled-components";

const Content = styled.div`
background-color: #343434;
height: 100vh;

.container{
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;

    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
    background-color: #343434;

    color: white;
}

h1, a:link, a:visited{
    text-align: center;
    color: white;
}
.items{
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;

    padding-top: 1.5em;
}
`
export default Content