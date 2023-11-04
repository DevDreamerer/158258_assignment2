const recordPopup = document.getElementById('recordPopup');
        const table = recordPopup.querySelector('table');

        function clearTextarea() {
            document.getElementById('textarea').value = '';
        }

        function submitForm() {
            const nickname = document.getElementById('nickname').value;
            const email = document.getElementById('email').value;
            const phone = document.getElementById('phone').value;
            const textarea = document.getElementById('textarea').value;
            const currentTime = new Date().toLocaleString();

            const newRow = table.insertRow(1);
            newRow.insertCell(0).textContent = currentTime;
            newRow.insertCell(1).textContent = nickname;
            newRow.insertCell(2).textContent = email;
            newRow.insertCell(3).textContent = phone;
            newRow.insertCell(4).textContent = textarea;

            document.getElementById('nickname').value = '';
            document.getElementById('email').value = '';
            document.getElementById('phone').value = '';
            document.getElementById('textarea').value = '';
        }

        function showRecords() {
            recordPopup.style.display = 'flex';
        }

        function closeRecords() {
            recordPopup.style.display = 'none';
        }