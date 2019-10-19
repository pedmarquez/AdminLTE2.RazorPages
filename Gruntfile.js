module.exports = function (grunt) {
    grunt.initConfig({
        copy: {
            main: {
                expand: true,
                cwd: 'node_modules/admin-lte/dist',
                src: '**',
                dest: 'wwwroot/'
            },
            components: {
                expand: true,
                cwd: 'node_modules/admin-lte/bower_components',
                src: '**',
                dest: 'wwwroot/lib/'
            }
        },
    });
    //grunt.loadNpmTasks("grunt-contrib-clean");
    grunt.loadNpmTasks("grunt-contrib-copy");
};