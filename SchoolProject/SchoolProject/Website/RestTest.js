function incrementNumber() {
    const number = parseInt(document.getElementById('incrementNumber').value);

    fetch('http://localhost:7285/Numbers/increment', {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(number)
    })
        .then(response => response.json())
        .then(data => {
            document.getElementById('incrementResult').textContent = `Erhöhte Zahl: ${data}`;
        })
        .catch(error => {
            console.error('Fehler beim Increment:', error);
        });
}

function calculateSum() {
    const zahlA = parseInt(document.getElementById('zahlA').value);
    const zahlB = parseInt(document.getElementById('zahlB').value);

    const sumData = {
        ZahlA: zahlA,
        ZahlB: zahlB
    };

    fetch('http://localhost:7285/Numbers/Sum', {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(sumData)
    })
        .then(response => response.json())
        .then(data => {
            document.getElementById('sumResult').textContent = `Summe: ${data}`;
        })
        .catch(error => {
            console.error('Fehler beim Berechnen der Summe:', error);
        });
}

function addStudent() {
    const date = document.getElementById('birthdate').value;
    const gender = document.getElementById('gender').value;
    const klasse = document.getElementById('class').value;

    const student = {
        geschlecht: gender,
        geburtstag: date,
        klasse: klasse
    };

    fetch('http://localhost:7285/Schul/AddSchueler', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(student)
    })
        .then(response => response.json())
        .then(data => {
            document.getElementById('responseAdded').textContent = `Schüler hinzugefügt: ${JSON.stringify(data)}`;
        })
        .catch(error => {
            console.error('Fehler beim Hinzufügen:', error);
        });
}

function studentAll() {
    fetch('http://localhost:7285/Schul/AlleSchueler', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }
    })
        .then(response => response.json())
        .then(data => {
            let html = '';
            console.log(data);
            data.forEach(element => {
                html += `<div class="student"> <br/>Geschlecht: ${element.geschlecht} <br/>Geburtstag: ${element.geburtstag}<br/>Klasse: ${element.klasse} <br/>Alter: ${element.alter} </div>`;
            });

            document.getElementById('content').innerHTML = html;
        })
        .catch(error => {
            console.error('Fehler beim Abrufen:', error);
        });
}



function studentAge() {
    fetch('http://localhost:7285/Schul/Durchschnittsalter', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }
    })
        .then(response => response.json())
        .then(data => {
            console.log(data);
            document.getElementById('responseAge').textContent = `Durchschnittsalter: ${data.durchschnittsalter}`;
        })
        .catch(error => {
            console.error('Fehler beim Abrufen des Durchschnittsalters:', error);
        });
}
function studentGender() {
    fetch('http://localhost:7285/Schul/Geschlecht', {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',
        },
    })
        .then(response => response.json())
        .then(data => {
            document.getElementById('responseGender').textContent = `Geschlechter: ${data}`;
        })
        .catch(error => {
            console.error('Fehler beim aufrufen:', error);
        });
}