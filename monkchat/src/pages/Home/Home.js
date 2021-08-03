import { Faixa1 } from './styles'

export default function Home(){
    return(
            <Faixa1>

                <div className="Header">
                    <div className="Logo">
                        <img src="./assets/images/imagem_2021-08-02_212515.png" alt=""/>
                    </div>
                    <div className="Line"></div>   
                    <div className="header-title">MonkChat</div>
                </div>

                <div className="F1-Container">

                    <div className="room-msg">
                        <div className="chat-info">
                            <div className="room-info">
                                <div className="room-name">
                                    Sala<span className="colon">:</span> <input type="text" id="name"/>
                                </div>
                                <div className="Nick">
                                    Nick<span className="colon">:</span> <input type="text" id="pasword"/>
                                </div>
                                <div className="Room-op">
                                    <button>Entrar</button>
                                    <button>Criar</button>
                                </div>
                            </div>
                        </div>

                        <div className="msg-area">
                            <div className="message-title">Mensagem<span className="colon">:</span></div>
                            <div className="typing-area">
                                <textarea placeholder="Digite sua mensagem aqui!" id="digitacao"></textarea>
                            </div>
                            <button className="send-button">Enviar</button>  
                        </div>
                    </div>
                    <div className="chat-area">
                        <div className="refresh">
                            <svg width="18" height="20" viewBox="0 0 18 20" fill="none" xmlns="http://www.w3.org/2000/svg">
                                <path d="M17 1V7H11" stroke="#F2EBDC" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/>
                                <path d="M1 19V13H7" stroke="#F2EBDC" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/>
                                <path d="M2.25634 7.66592C2.69672 6.31197 3.44516 5.10146 4.43183 4.14734C5.4185 3.19321 6.61125 2.52657 7.89878 2.20962C9.1863 1.89267 10.5266 1.93574 11.7947 2.33481C14 3.02881 16.0668 5.98418 17 7M2 14.325L4.10581 16.5082C5.03901 17.5241 6.19352 18.2661 7.46161 18.6652C8.7297 19.0643 10.07 19.1073 11.3576 18.7904C12.6451 18.4734 13.8378 17.8068 14.8245 16.8527C15.8112 15.8985 16.5596 14.688 17 13.3341" stroke="#F2EBDC" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/>
                            </svg>
                        </div>
                        
                        <div className="chat">
                            <div className="message">(15:02:01) <b>Brunex</b> Entrou na Sala... </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:02:21) <b>Brunex</b> Fala para <b>Todos:</b> Opa, Tudo bem ai? </div>
                            <div className="message">(15:03:25) <b>Brunex</b> Saiu da Sala...</div>
                        </div>
                        
                    </div>    
                </div>
        </Faixa1>

    );
}