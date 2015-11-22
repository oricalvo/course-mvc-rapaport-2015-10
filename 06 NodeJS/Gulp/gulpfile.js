var gulp = require("gulp");
var minify = require('gulp-minify');
var concat = require('gulp-concat');

gulp.task("minify", function () {
    gulp.src('scripts/*.js')
    .pipe(minify())
    .pipe(gulp.dest('dist'))
});

gulp.task("bundle", ["minify"], function () {
    gulp.src('dist/*min.js')
    .pipe(concat('all.js'))
    .pipe(gulp.dest('dist'))
});
