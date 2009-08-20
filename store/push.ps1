git add -A
git commit -m $args[0]
git checkout master
git merge development
git push
