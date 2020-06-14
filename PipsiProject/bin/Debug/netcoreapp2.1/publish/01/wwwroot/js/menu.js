//menu
let login = ['user', 'admin'];
let password = ['user', 'admin'];
let name = ['user', 'admin'];
let surname = ['user', 'admin'];
let date = ['2020-11-01', '2020-12-23'];
let street = ['ulica1', 'ulica2'];
let houseNumber = ['33', '12'];
let postCode = ['59-220', '66-222'];
let locality = ['Legnica', 'Lubiń'];
let telephoneNumber = ['+48663365892', '530025896'];
let i = 0;
let burger = document.querySelector('.burger');
let burgerItems = [...document.querySelectorAll('.fas')];
burger.addEventListener('click', () => {
    document.querySelector('nav.menuHamburger').classList.toggle('off');
    burgerItems.forEach((burgerItem) => {
        burgerItem.classList.toggle('off');
    })
})
//Contact
$('.socials').on('click', function () {
    $('body, html').animate({
        scrollTop: $('footer').offset().top
    }, 2000)
})


// $('.me,span.hide').on('click', function () {
//     $('.modal-me').toggleClass('active');
//     $('.wrapper').toggleClass('blur');
// })

//login
const btnLogin = document.querySelector('.in');
let logFlag = true;
btnLogin.addEventListener('click', () => {
    if (logFlag) {
        document.querySelector('.login').classList.toggle('active');
    } else {
        document.querySelector('.menuHamburger .in').textContent = "Zaloguj";
        logFlag = !logFlag;
    }
})

const btnLoginActive = document.querySelector('.login button');
btnLoginActive.addEventListener('click', () => {
    login.forEach((log, index) => {
        if (login[index].toLowerCase() === document.querySelector('.loginName input').value.toLowerCase() && password[index] === document.querySelector('.loginPassword input').value) {
            i = index;
            document.querySelector('.login').classList.remove('active');
            document.querySelector('.menuHamburger .in').textContent = "Wyloguj";
            document.querySelector('.modal .top p').textContent += login[i];

            document.querySelector('.name .input').textContent = name[i];
            document.querySelector('.surname .input').textContent = surname[i];
            document.querySelector('.date .input').textContent = date[i];
            document.querySelector('.street .input').textContent = street[i];
            document.querySelector('.sNumb .input').textContent = houseNumber[i];
            document.querySelector('.postCode .input').textContent = postCode[i];
            document.querySelector('.locality .input').textContent = locality[i];
            document.querySelector('.telephoneNumb .input').textContent = telephoneNumber[i];
            logFlag = !logFlag;
        }

    })
    if (logFlag) {
        alert('Niepoprawny login lub hasło, spróbuj ponownie');
        document.querySelector('.loginName input').value = "";
        document.querySelector('.loginPassword input').value = "";
    }
})
//rejestracja
const btnRegister = document.querySelector('.inscription');
const btnExit = document.querySelector('.exit');
btnRegister.addEventListener('click', () => {
    if (logFlag) {
        document.querySelector('.modal-register').classList.add('active');
        document.querySelector('.wrapper').classList.add('blur');
    } else alert('Wyloguj.');
})
btnExit.addEventListener('click', () => {

    document.querySelector('.modal-register').classList.remove('active');
    document.querySelector('.wrapper').classList.remove('blur');

})
const btnSend = document.querySelector('.down button');
btnSend.addEventListener('click', () => {
    const insert = [...document.querySelectorAll('.center input')];
    let check = 0;
    insert.forEach(item => {
        if (item.value === "") {
            check++;
        }
    })
    if (check === 0) {
        login.push(document.querySelector('.loginRegister input').value);
        password.push(document.querySelector('.passwordRegister input').value);
        name.push(document.querySelector('.nameRegister input').value);
        surname.push(document.querySelector('.surnameRegister input').value);
        date.push(document.querySelector('.dateRegister input').value);
        street.push(document.querySelector('.streetRegister input').value);
        houseNumber.push(document.querySelector('.numbstreetRegister input').value);
        postCode.push(document.querySelector('.postCodeRegister').value);
        locality.push(document.querySelector('.localityRegister input').value);
        telephoneNumber.push(document.querySelector('.telephoneRegister input').value);
        document.querySelector('.modal-register').classList.remove('active');
        document.querySelector('.wrapper').classList.remove('blur');
        alert('Rejestracja przebiegła pomyślnie. Możesz już zalogować.')
    } else alert('Uzupełnij wszystkie pola.');
})
//Me
const btnMe = document.querySelector('.me');
const btnHide = document.querySelector('.hide');
btnMe.addEventListener('click', () => {
    if (!logFlag) {
        document.querySelector('.modal-me').classList.add('active');
        document.querySelector('.wrapper').classList.add('blur');
    } else alert('Musisz być zalogowany');
})
btnHide.addEventListener('click', () => {
    document.querySelector('.modal-me').classList.remove('active');
    document.querySelector('.wrapper').classList.remove('blur');
})
//Me popup
const btnEdit = document.querySelector('.editCustomer')
let flag = false;




const edit = () => {
    if (!flag) {
        flag = !flag;
        btnEdit.textContent = "Zapisz";
        document.querySelector('.customerIn').classList.toggle('active');
    } else {
        flag = !flag;
        btnEdit.textContent = "Edytuj";
        document.querySelector('.customerIn').classList.toggle('active');
        password[i] = document.querySelector('.password').value;
        name[i] = document.querySelector('.nameIn').value;
        surname[i] = document.querySelector('.surnameIn').value;
        date[i] = document.querySelector('.dateIn').value;
        street[i] = document.querySelector('.streetIn').value;
        houseNumber[i] = document.querySelector('.sNumbIn').value;
        postCode[i] = document.querySelector('.postCodeIn').value;
        locality[i] = document.querySelector('.localityIn').value;
        telephoneNumber[i] = document.querySelector('.telephoneNumbIn').value;

    }
}
btnEdit.addEventListener('click', edit);