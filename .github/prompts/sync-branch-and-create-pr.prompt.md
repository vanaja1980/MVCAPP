---
description: Fetch the latest working and base branches, create a sync branch, merge the base branch into it, resolve conflicts safely, and open a pull request.
---

Synchronize my working branch with the repository's base branch and open a pull request.

## Identify branches and repository state

1. Inspect the repository, current branch, working-tree status, configured remotes, and upstream tracking branches. Treat the current branch as my working branch unless I specify another one.
2. Identify the repository's actual base branch. Prefer `master` if it exists on the remote; otherwise use `main`. If neither exists, or the intended base is ambiguous, ask me before proceeding. Do not assume that a branch named `master` exists.
3. If the working tree has uncommitted changes, stop and explain what is dirty. Do not discard, overwrite, or stash my changes without asking.
4. Fetch the latest remote refs. Check that the working branch and base branch both exist and report whether either has diverged from its upstream.
5. Preserve local commits. If the local working branch is behind its remote and can be fast-forwarded safely, update it fast-forward-only. If it has diverged, create the new branch from the local working branch and integrate the remote working-branch commits on the new branch. Never reset, rebase, or force-push the existing working branch.

## Create and synchronize a new branch

1. Create a new branch from the up-to-date working branch, using a descriptive unique name such as `sync/<working-branch>-with-<base-branch>`. Keep the original working branch unchanged after branch creation.
2. Merge the latest fetched base branch into the new branch. Do not merge the working branch into the base branch.
3. If conflicts occur, inspect the merge base, the most recent merge of the base branch into the working branch (if one exists), and the commits and diffs on both sides since then.
4. Resolve conflicts using the history and intent of the changes:
   - Preserve working-branch changes made after its most recent merge from the base branch when those changes are relevant to the conflict.
   - When the working branch has no relevant post-merge change for the conflict, prefer the latest base-branch change.
   - Combine both sides when both contain valid, compatible changes.
   - Do not resolve conflicts by blindly choosing “ours” or “theirs.” If the commit history or intent does not clearly establish which change should win, stop and ask me.
5. Run the relevant tests or build after resolving conflicts. Review the final diff and ensure no unrelated changes were introduced. If validation fails, report the failure and do not create a pull request.

## Push and open the pull request

1. Push only the new branch to the remote; do not force-push.
2. Open a pull request from the new branch into the identified base branch. Use the repository's available GitHub integration or authenticated CLI. Write a concise title and a description summarizing the synchronization and any conflict resolutions.
3. If authentication, push permissions, or pull-request creation is unavailable, preserve the new branch and report the exact remaining step and any relevant command or URL. Do not claim that the pull request was created unless its URL is confirmed.
4. Finish by reporting the source branch, new branch, base branch, merge/test result, and pull-request URL (or the specific blocker).
