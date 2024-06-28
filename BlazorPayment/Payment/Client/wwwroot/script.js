window.generateHash = function (key, text) {
    var hmac = CryptoJS.algo.HMAC.create(CryptoJS.algo.SHA256, key);
    hmac.update(text);
    var hash = hmac.finalize();
    return hash.toString();
}