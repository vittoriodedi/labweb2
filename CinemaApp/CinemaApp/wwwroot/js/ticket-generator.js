function generateTicketPDF(bigliettiData) {
    const doc = new jsPDF();

    doc.setFillColor(23, 23, 23);
    doc.rect(0, 0, 210, 40, 'F');

    doc.setTextColor(255, 255, 255);
    doc.setFont('helvetica', 'bold');
    doc.setFontSize(32);
    doc.text('CINEMANOVA', 105, 20, { align: 'center' });

    doc.setFontSize(14);
    doc.setFont('helvetica', 'normal');
    doc.text('I TUOI BIGLIETTI', 105, 30, { align: 'center' });

    doc.setTextColor(23, 23, 23);

    doc.setDrawColor(23, 23, 23);
    doc.setLineWidth(1);
    doc.line(20, 50, 190, 50);

    doc.setFillColor(245, 245, 245);
    doc.roundedRect(20, 60, 170, 50, 3, 3, 'F');

    doc.setFont('helvetica', 'bold');
    doc.setFontSize(18);
    doc.text(bigliettiData.film, 30, 75);

    doc.setFont('helvetica', 'normal');
    doc.setFontSize(12);
    doc.text(`Data: ${bigliettiData.data}`, 30, 85);
    doc.text(`Orario: ${bigliettiData.orario}`, 30, 95);
    doc.text(`Sala: ${bigliettiData.sala}`, 120, 85);
    doc.text(`Email: ${bigliettiData.email}`, 120, 95);

    doc.setFillColor(23, 23, 23);
    doc.rect(20, 120, 170, 10, 'F');
    doc.setTextColor(255, 255, 255);
    doc.setFont('helvetica', 'bold');
    doc.setFontSize(12);
    doc.text('DETTAGLI BIGLIETTI', 105, 127, { align: 'center' });

    let y = 140;
    doc.setTextColor(23, 23, 23);
    doc.setFillColor(240, 240, 240);
    doc.setLineWidth(0.1);

    doc.rect(20, y-10, 170, 10, 'F');
    doc.setFont('helvetica', 'bold');
    doc.text('POSTO', 30, y-3);
    doc.text('CODICE PRENOTAZIONE', 90, y-3);
    doc.text('PREZZO', 170, y-3);

    doc.setFont('helvetica', 'normal');
    doc.setFontSize(11);

    let totalePrezzi = 0;
    let rigaAlternata = false;

    bigliettiData.biglietti.forEach(biglietto => {
        if (rigaAlternata) {
            doc.setFillColor(248, 248, 248);
            doc.rect(20, y, 170, 10, 'F');
        }

        doc.text(`Fila ${biglietto.fila} - Posto ${biglietto.numero}`, 30, y+6);
        doc.text(biglietto.codice, 90, y+6);
        doc.text(`€ ${biglietto.prezzo}`, 170, y+6);

        y += 10;
        totalePrezzi += parseFloat(biglietto.prezzo);
        rigaAlternata = !rigaAlternata;
    });

    y += 5;
    doc.setDrawColor(23, 23, 23);
    doc.setLineWidth(0.5);
    doc.line(20, y, 190, y);
    y += 10;
    doc.setFont('helvetica', 'bold');
    doc.setFontSize(12);
    doc.text('TOTALE', 90, y+5);
    doc.text(`€ ${totalePrezzi.toFixed(2)}`, 170, y+5);
    

    y = 240;
    doc.setFillColor(245, 245, 245);
    doc.roundedRect(20, y, 170, 30, 3, 3, 'F');

    doc.setFont('helvetica', 'normal');
    doc.setFontSize(10);
    doc.setTextColor(100, 100, 100);
    doc.text('Presentare questo biglietto all\'ingresso della sala.', 105, y+12, { align: 'center' });
    doc.text('Ti auguriamo una buona visione!', 105, y+22, { align: 'center' });

    const oggi = new Date();
    doc.setFontSize(8);
    doc.text(`Documento generato il ${oggi.toLocaleDateString('it-IT')} alle ${oggi.toLocaleTimeString('it-IT')}`, 105, 285, { align: 'center' });

    doc.setDrawColor(23, 23, 23);
    doc.setLineWidth(1);
    doc.line(20, 275, 190, 275);

    doc.save('biglietti_cinemanova.pdf');
}

window.ticketGenerator = {
    generateTicketPDF: generateTicketPDF
};