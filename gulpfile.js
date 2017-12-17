var ftp = require('vinyl-ftp');
var gutil = require('gulp-util');
var debug = require('gulp-debug');
var minimist = require('minimist');
var args = minimist(process.argv.slice(2));

gulp.task('deploy', function() {
  var remotePath = '/httpdocs/api.netify.io/';
  var conn = ftp.create({
    host: 'netify.io',
    user: args.user,
    password: args.password,
    log: gutil.log
  });
  gulp.src(['publish/**/*'])
    .pipe(debug())
    .pipe(conn.dest(remotePath));
});