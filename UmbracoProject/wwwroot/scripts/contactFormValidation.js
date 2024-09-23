document.addEventListener('DOMContentLoaded', function () {
    const form = document.getElementById('contactForm');
    const nameInput = form.querySelector('#input-name');
    const emailInput = form.querySelector('#input-email');
    const phoneInput = form.querySelector('#input-phone');
    const nameMessage = form.querySelector('#input-name-message');
    const emailMessage = form.querySelector('#input-email-message');
    const phoneMessage = form.querySelector('#input-phone-message');

    const emailRegex = /^(?=.{1,100}$)[a-zA-Z0-9._%+-]{1,64}@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    const nameRegex = /[a-zA-Z]/;
    const phoneRegex = /^0\d{9}$/;

    function validateInput(inputElement, regex, messageElement, errorMessage) {
        const value = inputElement.value;

        if (!value || value.trim() === '') {
            messageElement.textContent = 'This field cannot be empty.';
            messageElement.style.display = 'block';
            inputElement.classList.add('input-error');
            inputElement.classList.remove('input-valid');
            return false;
        }

        if (!regex.test(value)) {
            messageElement.textContent = errorMessage;
            messageElement.style.display = 'block';
            inputElement.classList.add('input-error');
            inputElement.classList.remove('input-valid');
            return false;
        } else {
            messageElement.style.display = 'none';
            inputElement.classList.remove('input-error');
            inputElement.classList.add('input-valid');
            return true;
        }
    }

    function validateForm(event) {
        let isValid = true;
        isValid = validateInput(nameInput, nameRegex, nameMessage, 'Name must contain at least one letter.') && isValid;
        isValid = validateInput(emailInput, emailRegex, emailMessage, 'Invalid email address.') && isValid;
        isValid = validateInput(phoneInput, phoneRegex, phoneMessage, 'Phone number must start with 0 and be 10 digits long.') && isValid;

        if (!isValid) {
            event.preventDefault();
        }
    }

    nameInput.addEventListener('blur', function () {
        validateInput(nameInput, nameRegex, nameMessage, 'Name must contain at least one letter.');
    });
    emailInput.addEventListener('blur', function () {
        validateInput(emailInput, emailRegex, emailMessage, 'Invalid email address.');
    });
    phoneInput.addEventListener('blur', function () {
        validateInput(phoneInput, phoneRegex, phoneMessage, 'Phone number must start with 0 and be 10 digits long.');
    });

    form.addEventListener('submit', function (event) {
        validateForm(event);
    });
});