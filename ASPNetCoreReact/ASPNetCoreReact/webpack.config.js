const path = require('path');

module.exports = {
    entry: './wwwroot/Source/app.js',
    output: {
        path: path.resolve(__dirname, 'wwwroot/dist'),
        filename: 'bundle.js'
    }
};