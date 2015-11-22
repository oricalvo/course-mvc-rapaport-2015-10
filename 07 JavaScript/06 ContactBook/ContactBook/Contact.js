var Contact = (function () {

    function Contact(name, email) {
        BookItem.call(this);

        this.name = name;
        this.email = email;
    }

    Contact.prototype = Object.create(BookItem.prototype);

    Contact.prototype.dump = function () {
        console.log(this.name + ", " + this.email);
    }

    return Contact;

})();
