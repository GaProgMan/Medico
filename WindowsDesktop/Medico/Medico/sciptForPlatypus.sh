﻿#!/bin/sh

export DYLD_FALLBACK_LIBRARY_PATH="/Library/Frameworks/Mono.framework/Versions/Current/lib:$DYLD_FALLBACK_LIBRARY_PATH:/usr/lib"

exec /Library/Frameworks/Mono.framework/Versions/Current/bin/mono ./Medico.exe