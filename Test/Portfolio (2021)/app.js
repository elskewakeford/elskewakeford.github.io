//Linked

const navSlide = () => {
    const burger = document.querySelector('.burger');
    const nav = document.querySelector('.nav-links');
    const navLinks = document.querySelector('.nav-links li');
    //Toggle Nav
    burger.addEventListener('click', () => {
        nav.classList.toggle('nav-active');
    });

    //Animate Links
    navLinks.forEach((link, index) => {
        link.style.animation = `navLinkFade 0.5s ease forwards ${index / 7 + 1.5}s`
    });

}

navSlide();

