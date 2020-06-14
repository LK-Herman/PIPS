const getUsers = () => {
    const usersNumber = 39;
    const usersGender = 'male,female';
    const url = `https://randomuser.me/api/?results=${usersNumber}&gender=${usersGender}`;
    fetch(url)
        .then((response) => {
            if (response.status !== 200) {
                throw Error("To nie jest odpowiedź 200")
            } else {
                return response.json();
            }
        })
        .then(json => showUsers(json.results))
        .catch(err => console.log(err));
}
const showUsers = (users) => {
    const resultArea = document.querySelector('.user-list');
    resultArea.textContent = "";
    users.forEach((user) => {
        const item = document.createElement('div');
        item.className = 'user contact';
        item.innerHTML = `<div class="user__name">${user.name.title.toUpperCase()} ${user.name.first.toUpperCase()} ${user.name.last.toUpperCase()}</div>
        <img class = "user__image" src="${user.picture.medium}">`
        resultArea.appendChild(item);
    })

}
document.querySelector('button').addEventListener('click', getUsers);