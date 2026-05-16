#!/bin/bash

# === Parameters ===
project_dir="D:\Self-Study\C#\16- C# OOP"
repo_url="https://github.com/osama-mohamoud2006/16-OOP-As-It-Should-Be-In-CSharp.git"

# === Go to project directory ===
cd "$project_dir" || { echo "Directory not found"; exit 1; }

# === Update .gitignore ===
echo ".vs/" >> .gitignore 2>/dev/null

# === Init git if not exists ===
if [ ! -d ".git" ]; then
    git init
    git branch -M main
fi

# === Set remote ===
git remote remove origin 2>/dev/null
git remote add origin "$repo_url"

# === Commit and push ===
git add .
git commit -m "Auto commit: $(date)" || echo "Nothing to commit"
git push -u origin main