import styled from "styled-components"

const Faixa1 = styled.div`

    background-color: #583BBF;
    padding: 2em 2em 4.4em;


.Header{
    display: flex;
    flex-direction: row;
    align-items: center;

    font-family: Monteserrat-Bold;
    margin-bottom: 2.25em;
}

.Line{
    background-image: linear-gradient(#BA9D4C, #F3D991);
    width: 0.25em;
    height: 3.5em;
    border-radius: 0.625em;
    margin-right: 1.6875em;
}
.Header svg{
    margin-right: 0.8125em;
}

.header-title{
    color: white;
    font-size: 2.25em;
}

.F1-Container{
    display: flex;
    flex-direction: row;
    background-color: rgba(0, 0, 0 , 0.12);

    padding: 0px 3.1875em 3em;
    margin-left: 1.9375em;

}

.room-msg{
    display: flex;
    flex-direction: column;

    margin-right: 3.125em;

    padding-top: 3.25em;
}

.chat-info{
    display: flex;
    flex-direction: row;

    font-family: Monteserrat-Bold;
    color: white;
}

.room-name{
    margin-bottom: 0.4375em;
    font-size: 1.5em;
    padding-left: 0.25em;
}

.Nick{
    margin-bottom: 0.8125em;
    font-size: 1.5em;
}

.Room-op{
    display: flex;
    flex-direction: row-reverse;

    margin-top: 0.8125em;
}

.Room-op button{
    font-family: Monteserrat-Bold;
    color: white;

    border-radius: 1.25em;
    background-color: #50B4BF;
    border: none;
    padding: 0.4375em 1.25em;
    margin: 0px 0.21875em;
    font-size: 1em;
    line-height: 1.25em;

    transition: 0.5s;
}

#name, #pasword{
    font-family: Monteserrat-regular;
    color: black;
    font-weight: 400;
    margin-left: 1.0625em;

    padding: 0.3125em 0px;
    border-radius: 0.3125em;
    border: none;
}

.msg-area{
    margin-top: 3.9375em;
}

.message-title{
    font-family: Monteserrat-Bold;
    color: white;
    font-size: 1.5em;

    margin-bottom: 0.5em;
}

#digitacao{
    resize: none;
    width: 16.6875em;
    height: 13.375em;
    background: #FFFFFF;
    border-radius: 0.3125em;
    font-family: Monteserrat-regular;
}


.send-button{
    font-family: Monteserrat-Bold;
    color: white;

    border-radius: 1.25em;
    background-color: #50B4BF;
    border: none;
    padding: 0.4375em 1.25em;
    font-size: 1em;
    line-height: 1.25em;

    margin-top: 0.5em;

    transition: 0.5s;
}

.send-button:hover, .Room-op button:hover{
    background-color: #3b97a1;
   }   

.msg-area button{
    margin-left: 11.875em;
}

.chat-area{
    margin-top: 1.3125em;
}

.chat-area svg {
    margin-bottom: 0.6875em;
}

.refresh{
    display: flex;
    flex-direction: row-reverse;

    transition: 0.5s;
}

.refresh svg{
    transition: 1.2s;
}
.refresh svg:hover{
    transform: rotate(360deg);
}

.chat{
    display: flex;
    flex-direction: column;
    background: rgba(192, 65, 224, 0.19);
    border-radius: 3px;

    overflow-y: scroll;
    width: 58.625em;
    height: 27.375em;

    padding: 1.3125em 0px 0px 1.625em;
}

.chat::-webkit-scrollbar-track
{
	border-radius: 0.625em;
	background-color: #3E006F;
}

.chat::-webkit-scrollbar
{
	width: 0.4375em;
    border-radius: 0.625em;
	background-color: #d1d1d1;
}

.chat::-webkit-scrollbar-thumb
{
	border-radius: 0.625em;
	background-color: #CBCBCB;
}


.message{
    color: white;
    font-family: Monteserrat-regular;
    margin-bottom: 0.6875em;
}

@media (max-width: 1024px) {

    .Faixa1{
        padding: 1em 1em 1.1em;
    }

    .Header{
        flex-direction: column;
    }
    .header-title{
        font-size: 2em;
    }
    .Header svg{
        width: 3.875em;
    }    
    .Line{
        display: none;
    }

    .F1-Container{
        padding: 0.625em;
        margin-left: 0px;
        flex-direction: column;
    }
    .chat-info, .room-info{
        width: 116%;
        padding: 0px;
    }
    .room-name, .Nick{
        padding: 0px;
        width: 104%;
        font-size: 1.25em;
        align-items: center;
    }
    .room-name{
        margin-bottom: 0.3125em;
    }
    .colon{
        display: none;
    }
    #name{
        margin: 0px;
        margin-left: 1.5em;
        width: 74.491%;
    }
    #pasword{
        margin: 0px;
        margin-left: 1.25em;
        width: 74.491%;
    }
    .Room-op{
        flex-direction: column;
        width: 104%;
    }

    .Room-op button{
        width: 95.278%;
        border-radius: 0.25em;
        margin: 0px 0px 0.3125em 0px;
    }

    .msg-area{
        width: 114.935%;
    }
    #digitacao{
        width: 98.09%;
    }
    .typing-area{
        width: 100%;
    }

    .send-button{
        border-radius: 0.25em;
        width: 100%;
    }
    .msg-area button{
        margin: 0px;
        text-align: center;
        width: 100%;

    }

    .chat, .refresh{
        width: 94.06%;
        padding: 1.625em 0px 0.625em 0.625em;
    }

    .chat{
        height: 17.125em;
    }

    .chat-area{
        width: 100%;
        justify-content: space-between;
    }
}
`

export { Faixa1 };