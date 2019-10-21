/// <binding BeforeBuild='all' ProjectOpened='all' />
module.exports = function (grunt) {
    grunt.initConfig({
        clean: ["wwwroot/lib/*"],
        copy: {
            main: {
                expand: true,
                cwd: 'node_modules/admin-lte/dist',
                src: '**',
                dest: 'wwwroot/'
            },
            jqueryval: {
                expand: true,
                cwd: 'node_modules/jquery-validation',
                src: '**',
                dest: 'wwwroot/lib/jquery-validation/'
            },
            jqueryvalunob: {
                expand: true,
                cwd: 'node_modules/jquery-validation-unobtrusive/dist',
                src: '**',
                dest: 'wwwroot/lib/jquery-validation-unobtrusive/'
            },
            components: {
                expand: true,
                cwd: 'node_modules/admin-lte/bower_components',
                src: '**',
                dest: 'wwwroot/lib/'
            }
        },
    });
    grunt.loadNpmTasks("grunt-contrib-clean");
    grunt.loadNpmTasks("grunt-contrib-copy");

    grunt.registerTask("default", ['clean', 'copy']);
};