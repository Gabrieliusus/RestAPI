const baseUrl = "https://localhost:7285";

function addSchueler() {
    const schueler = {
        name: document.getElementById("schueler-name").value,
        klasse: document.getElementById("schueler-klasse").value,
        geburtstag: document.getElementById("schueler-geburtstag").value,
        geschlecht: document.getElementById("schueler-geschlecht").value,
    };

    fetch(`${baseUrl}/Schule/Schueler`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(schueler)
    })
    .then(res => res.json())
    .then(data => document.getElementById("schueler-antwort").innerText = "Hinzugefügt: " + JSON.stringify(data));
}

function addLehrer() {
    const lehrer = {
        name: document.getElementById("lehrer-name").value,
        fachgebiet: document.getElementById("lehrer-fach").value,
        geburtstag: document.getElementById("lehrer-geburtstag").value,
        geschlecht: document.getElementById("lehrer-geschlecht").value,
    };

    fetch(`${baseUrl}/Schule/Lehrer`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(lehrer)
    })
    .then(res => res.json())
    .then(data => document.getElementById("lehrer-antwort").innerText = "Hinzugefügt: " + JSON.stringify(data));
}

function addKlasse() {
    const klasse = {
        name: document.getElementById("klasse-name").value
    };

    fetch(`${baseUrl}/Schule/Klassen`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(klasse)
    })
    .then(res => res.json())
    .then(data => document.getElementById("klasse-antwort").innerText = "Hinzugefügt: " + JSON.stringify(data));
}

function getSchueler() {
    fetch(`${baseUrl}/Schule/Schueler`)
        .then(res => res.json())
        .then(data => {
            const list = data.map(s => `<div class='entry'>${s.name} (${s.klasse}) - ${s.geschlecht}</div>`).join("");
            document.getElementById("schueler-liste").innerHTML = list;
        });
}

function getLehrer() {
    fetch(`${baseUrl}/Schule/Lehrer`)
        .then(res => res.json())
        .then(data => {
            const list = data.map(l => `<div class='entry'>${l.name} - ${l.fachgebiet} (${l.geschlecht})</div>`).join("");
            document.getElementById("lehrer-liste").innerHTML = list;
        });
}

function getKlassen() {
    fetch(`${baseUrl}/Schule/Klassen`)
        .then(res => res.json())
        .then(data => {
            const list = data.map(k => `<div class='entry'>${k.name}</div>`).join("");
            document.getElementById("klassen-liste").innerHTML = list;
        });
}

then(data => {
    console.log("Schueler hinzugefügt:", data);
    document.getElementById("schueler-antwort").innerText = "Hinzugefügt: " + JSON.stringify(data);
    getSchueler();
});
