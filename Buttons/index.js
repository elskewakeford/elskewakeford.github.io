for (let i = 1; i <= 100; i++) {
    const newButton = document.createElement('button');
    newButton.innerText = "";

    const newPosition = document.querySelector('div');
    newPosition.insertAdjacentElement('afterbegin', newButton);
}

function MakeRandColor() {
    const r = Math.floor(Math.random() * 255);
    const g = Math.floor(Math.random() * 255);
    const b = Math.floor(Math.random() * 255);
    return `rgb(${r}, ${g}, ${b})`;
}

const buttons = document.querySelectorAll('button');


for (let button of buttons) {
    button.addEventListener('click', function () {
        const newColor = MakeRandColor()
        button.style.backgroundColor = newColor;
        button.innerText = newColor;
    })
}
