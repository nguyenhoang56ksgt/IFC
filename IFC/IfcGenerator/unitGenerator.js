function unitGenerator(startNum) {
  const L1 = `#${startNum}= IFCSIUNIT(*,.LENGTHUNIT.,$,.METRE.);`;
  const L2 = `#${startNum + 1}= IFCSIUNIT(*,.AREAUNIT.,$,.SQUARE_METRE.);`;
  const L3 = `#${startNum + 2}= IFCSIUNIT(*,.VOLUMEUNIT.,$,.CUBIC_METRE.);`;
  const L4 = `#${startNum + 3}= IFCSIUNIT(*,.PLANEANGLEUNIT.,$,.RADIAN.);`;
  const L5 = `#${startNum + 4}= IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);`;
  const L6 = `#${startNum + 5}= IFCUNITASSIGNMENT((#${startNum},#${startNum + 1},#${startNum + 2},#${startNum + 3},#${
    startNum + 4
  }));`;

  const result = L1 + '\n' + L2 + '\n' + L3 + '\n' + L4 + '\n' + L5 + '\n' + L6;

  return { endNum: startNum + 6, result };
}

module.exports = { unitGenerator };
