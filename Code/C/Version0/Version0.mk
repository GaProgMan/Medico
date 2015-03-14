##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Debug
ProjectName            :=Version0
ConfigurationName      :=Debug
WorkspacePath          := "/Users/jamietaylor/Code Projects/Medico/Code/C"
ProjectPath            := "/Users/jamietaylor/Code Projects/Medico/Code/C/Version0"
IntermediateDirectory  :=./Debug
OutDir                 := $(IntermediateDirectory)
CurrentFileName        :=
CurrentFilePath        :=
CurrentFileFullPath    :=
User                   :=GaProgMan
Date                   :=2015-03-14
CodeLitePath           :="/Users/jamietaylor/Library/Application Support/codelite"
LinkerName             :=/usr/bin/g++ 
SharedObjectLinkerName :=/usr/bin/g++ -dynamiclib -fPIC
ObjectSuffix           :=.o
DependSuffix           :=.o.d
PreprocessSuffix       :=.i
DebugSwitch            :=-g 
IncludeSwitch          :=-I
LibrarySwitch          :=-l
OutputSwitch           :=-o 
LibraryPathSwitch      :=-L
PreprocessorSwitch     :=-D
SourceSwitch           :=-c 
OutputFile             :=$(IntermediateDirectory)/$(ProjectName)
Preprocessors          :=
ObjectSwitch           :=-o 
ArchiveOutputSwitch    := 
PreprocessOnlySwitch   :=-E
ObjectsFileList        :="Version0.txt"
PCHCompileFlags        :=
MakeDirCommand         :=mkdir -p
LinkOptions            :=  
IncludePath            :=  $(IncludeSwitch). $(IncludeSwitch). 
IncludePCH             := 
RcIncludePath          := 
Libs                   := 
ArLibs                 :=  
LibPath                := $(LibraryPathSwitch). 

##
## Common variables
## AR, CXX, CC, AS, CXXFLAGS and CFLAGS can be overriden using an environment variables
##
AR       := /usr/bin/ar rcu
CXX      := /usr/bin/g++ 
CC       := /usr/bin/gcc 
CXXFLAGS :=  -g -O0 -Wall $(Preprocessors)
CFLAGS   :=  -g -O0 -Wall $(Preprocessors)
ASFLAGS  := 
AS       := /usr/bin/as 


##
## User defined environment variables
##
CodeLiteDir:=/Applications/codelite.app/Contents/SharedSupport/
Objects0=$(IntermediateDirectory)/main.cpp$(ObjectSuffix) $(IntermediateDirectory)/Data_UserClass.cpp$(ObjectSuffix) $(IntermediateDirectory)/Data_Medication.cpp$(ObjectSuffix) 



Objects=$(Objects0) 

##
## Main Build Targets 
##
.PHONY: all clean PreBuild PrePreBuild PostBuild
all: $(OutputFile)

$(OutputFile): $(IntermediateDirectory)/.d $(Objects) 
	@$(MakeDirCommand) $(@D)
	@echo "" > $(IntermediateDirectory)/.d
	@echo $(Objects0)  > $(ObjectsFileList)
	$(LinkerName) $(OutputSwitch)$(OutputFile) @$(ObjectsFileList) $(LibPath) $(Libs) $(LinkOptions)

$(IntermediateDirectory)/.d:
	@test -d ./Debug || $(MakeDirCommand) ./Debug

PreBuild:


##
## Objects
##
$(IntermediateDirectory)/main.cpp$(ObjectSuffix): main.cpp $(IntermediateDirectory)/main.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/Users/jamietaylor/Code Projects/Medico/Code/C/Version0/main.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/main.cpp$(ObjectSuffix) $(IncludePath)
$(IntermediateDirectory)/main.cpp$(DependSuffix): main.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT$(IntermediateDirectory)/main.cpp$(ObjectSuffix) -MF$(IntermediateDirectory)/main.cpp$(DependSuffix) -MM "main.cpp"

$(IntermediateDirectory)/main.cpp$(PreprocessSuffix): main.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) $(IntermediateDirectory)/main.cpp$(PreprocessSuffix) "main.cpp"

$(IntermediateDirectory)/Data_UserClass.cpp$(ObjectSuffix): Data/UserClass.cpp $(IntermediateDirectory)/Data_UserClass.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/Users/jamietaylor/Code Projects/Medico/Code/C/Version0/Data/UserClass.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/Data_UserClass.cpp$(ObjectSuffix) $(IncludePath)
$(IntermediateDirectory)/Data_UserClass.cpp$(DependSuffix): Data/UserClass.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT$(IntermediateDirectory)/Data_UserClass.cpp$(ObjectSuffix) -MF$(IntermediateDirectory)/Data_UserClass.cpp$(DependSuffix) -MM "Data/UserClass.cpp"

$(IntermediateDirectory)/Data_UserClass.cpp$(PreprocessSuffix): Data/UserClass.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) $(IntermediateDirectory)/Data_UserClass.cpp$(PreprocessSuffix) "Data/UserClass.cpp"

$(IntermediateDirectory)/Data_Medication.cpp$(ObjectSuffix): Data/Medication.cpp $(IntermediateDirectory)/Data_Medication.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/Users/jamietaylor/Code Projects/Medico/Code/C/Version0/Data/Medication.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/Data_Medication.cpp$(ObjectSuffix) $(IncludePath)
$(IntermediateDirectory)/Data_Medication.cpp$(DependSuffix): Data/Medication.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT$(IntermediateDirectory)/Data_Medication.cpp$(ObjectSuffix) -MF$(IntermediateDirectory)/Data_Medication.cpp$(DependSuffix) -MM "Data/Medication.cpp"

$(IntermediateDirectory)/Data_Medication.cpp$(PreprocessSuffix): Data/Medication.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) $(IntermediateDirectory)/Data_Medication.cpp$(PreprocessSuffix) "Data/Medication.cpp"


-include $(IntermediateDirectory)/*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) ./Debug/*$(ObjectSuffix)
	$(RM) ./Debug/*$(DependSuffix)
	$(RM) $(OutputFile)
	$(RM) "../.build-debug/Version0"


