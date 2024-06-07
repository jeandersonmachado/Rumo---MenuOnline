const inputNumber = document.getElementById("input-number");
const inputText = document.getElementById("input-text");
const sendButton = document.getElementById("send-button");
const nomeMesa = document.querySelectorAll("#nome-mesa p");
const nomeError = document.getElementById("nome-error");
const mesaError = document.getElementById("mesa-error");
const overlay = document.getElementById("overlay");
const inputContainer = document.getElementById("input-container");
const getQuantity = document.querySelectorAll('.get-quantity');
const total = document.getElementById('total');
const comprarButton = document.getElementById('comprar');
const time = document.getElementById('time');


// Input do nome e da mesa
sendButton.addEventListener("click", () => {
    const nome = inputText.value;
    const mesa = inputNumber.value;

    if (!nome) {
        nomeError.textContent = "Favor insira seu nome";
        nomeError.style.color = "red";
    } else {
        nomeError.textContent = "";
    }

    if (!mesa) {
        mesaError.textContent = "Favor insira sua mesa";
        mesaError.style.color = "red";
    } else {
    mesaError.textContent = "";
    }

    if (nome && mesa) {
        nomeMesa[0].textContent = `Bem vindo, ${nome}`;
        nomeMesa[1].textContent = `Mesa: ${mesa}`;
        overlay.style.visibility = "hidden";
        inputContainer.style.visibility = "hidden";
    }
})
 // Atualizar o valor total
const values = [25.50, 20.50, 18.00, 10.50, 8.50, 6.30];
let totalValue = 0;
let previousQuantities = Array(getQuantity.length).fill(0);

function updateTotal() {
    totalValue = 0;
    for (let i = 0; i < getQuantity.length; i++) {
        let quantity = getQuantity[i].value;
        if (quantity) {
            totalValue += values[i] * quantity;
        }
    }
    total.innerText = `Total: R$ ${totalValue.toFixed(2)}`;
}

for (let i = 0; i < getQuantity.length; i++) {
    getQuantity[i].addEventListener("input", function () {
        totalValue -= values[i] * previousQuantities[i];
        previousQuantities[i] = parseInt(getQuantity[i].value) || 0;
        totalValue += values[i] * previousQuantities[i];
        total.innerText = `Total: R$ ${totalValue.toFixed(2)}`;
    });
}

// tempo para preparo
comprarButton.addEventListener("click", function () {
    let numeroAleatorio = Math.floor(Math.random() * 100) + 1;

    let novoElemento = document.createElement("div");
    novoElemento.className = "contador";
    novoElemento.textContent = "Seu pedido ficará pronto em: 59 segundos";

    time.appendChild(novoElemento);

    let tempo = 5;

    let intervalo = setInterval(function () {
        novoElemento.textContent = `O pedido ${numeroAleatorio} ficará pronto em: ${tempo} segundos`;
        tempo--;

        if (tempo < 0) {
            clearInterval(intervalo);
            novoElemento.textContent = "Seu pedido está pronto"
            novoElemento.style.backgroundColor = "green"

        }
    }, 1000);
});